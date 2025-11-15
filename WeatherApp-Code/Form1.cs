using Newtonsoft.Json;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        // Konstanta untuk menyimpan API Key dari WeatherAPI
        private const string API_KEY = "7a975eb10f614bc2a8b43355252810";
        // URL API untuk mendapatkan data forecast (ramalan cuaca)
        private const string FORECAST_API_URL = "http://api.weatherapi.com/v1/forecast.json";
        // HttpClient untuk melakukan request HTTP ke API
        private HttpClient httpClient;

        // PictureBox untuk menampilkan icon cuaca utama
        private PictureBox pictureBoxWeather;
        // PictureBox untuk menampilkan icon cuaca 5 hari ke depan
        private PictureBox picDay1;
        private PictureBox picDay2;
        private PictureBox picDay3;

        // Constructor Form1 yang dipanggil saat form pertama kali dibuat
        public Form1()
        {
            InitializeComponent();
            // Inisialisasi HttpClient untuk melakukan request API
            httpClient = new HttpClient();
            string iconFolder = Path.Combine(Application.StartupPath, "icons");
            // Set folder icon ke class WeatherIcon
            WeatherIcon.IconFolder(iconFolder);

            // Inisialisasi semua PictureBox untuk icon cuaca
            InitializeWeatherIcons();
        }

        // Fungsi untuk menginisialisasi PictureBox icon cuaca
        private void InitializeWeatherIcons()
        {
            // Buat PictureBox untuk icon cuaca utama
            pictureBoxWeather = new PictureBox();
            pictureBoxWeather.Location = new Point(35, 47); // Posisi X=35, Y=47
            pictureBoxWeather.Size = new Size(140, 140); // Ukuran 140x140 pixel
            pictureBoxWeather.SizeMode = PictureBoxSizeMode.Zoom; // Mode zoom agar gambar proporsional
            pictureBoxWeather.BackColor = Color.Transparent; // Background transparan
            panelForecast.Controls.Add(pictureBoxWeather); // Tambahkan ke panel forecast
            pictureBoxWeather.BringToFront(); // Bawa ke depan agar tidak tertutup kontrol lain

            // Buat PictureBox untuk icon ramalan 5 hari
            picDay1 = CreateForecastIcon(panelDay1);
            picDay2 = CreateForecastIcon(panelDay2);
            picDay3 = CreateForecastIcon(panelDay3);
        }

        // Fungsi helper untuk membuat PictureBox icon forecast di dalam panel
        private PictureBox CreateForecastIcon(Panel panel)
        {
            var pictureBox = new PictureBox();
            pictureBox.Location = new Point(53, 23); // Posisi di dalam panel
            pictureBox.Size = new Size(80, 80); // Ukuran 76x71 pixel
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Mode zoom
            pictureBox.BackColor = Color.Transparent; // Background transparan
            panel.Controls.Add(pictureBox); // Tambahkan ke panel
            panel.BringToFront(); // Bawa panel ke depan
            return pictureBox;
        }

        // Fungsi ketika tombol Search diklik
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            // Ambil teks dari textbox dan hapus spasi di awal/akhir
            string city = txtCity.Text.Trim();

            // Validasi: cek apakah nama kota kosong
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please enter a city name!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Disable tombol search agar tidak bisa diklik saat loading
            btnSearch.Enabled = false;
            btnSearch.Text = "Loading..."; // Ubah teks tombol menjadi "Loading..."
            lblStatus.Text = "Fetching weather data..."; // Update status
            lblStatus.ForeColor = Color.White; // Warna teks putih

            // Panggil Fungsi async untuk mendapatkan data cuaca
            await GetWeatherData(city);

            // Enable kembali tombol search setelah selesai
            btnSearch.Enabled = true;
            btnSearch.Text = "Search"; // Kembalikan teks tombol
        }

        // Fungsi async untuk mengambil data cuaca dari API
        private async Task GetWeatherData(string city)
        {
            try
            {
                // Buat URL dengan parameter: API key, nama kota, jumlah hari forecast, dan AQI
                string url = $"{FORECAST_API_URL}?key={API_KEY}&q={city}&days=5&aqi=yes&alerts=yes";
                // Kirim request GET ke API
                HttpResponseMessage response = await httpClient.GetAsync(url);

                // Cek apakah response berhasil (status code 200)
                if (response.IsSuccessStatusCode)
                {
                    // Baca content response sebagai string JSON
                    string json = await response.Content.ReadAsStringAsync();
                    // Deserialize JSON menjadi object Root
                    Root weatherData = JsonConvert.DeserializeObject<Root>(json)!;
                    // Tampilkan data cuaca di UI
                    DisplayWeatherData(weatherData);
                }
                else
                {
                    // Jika gagal, tampilkan pesan kota tidak ditemukan
                    lblStatus.Text = "City not found!";
                    lblStatus.ForeColor = Color.FromArgb(255, 100, 100); // Warna merah
                    // Bersihkan tampilan cuaca
                    ClearWeatherDisplay();
                }
            }
            catch (Exception ex)
            {
                // Tangkap error dan tampilkan pesan error
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error loading data";
                lblStatus.ForeColor = Color.FromArgb(255, 100, 100);
            }
        }

        // Fungsi untuk menampilkan data cuaca ke UI
        private void DisplayWeatherData(Root data)
        {
            // Validasi: cek apakah data null
            if (data == null) return;

            // Tampilkan data lokasi
            lblCity.Text = data.location.name; // Nama kota
            lblCountry.Text = $"{data.location.region}, {data.location.country}"; // Region dan negara
            lblLastUpdate.Text = $"Last updated: \n{data.current.last_updated}"; // Waktu update terakhir

            // Tampilkan data cuaca saat ini
            lblTemp.Text = $"{data.current.temp_c}°C"; // Suhu dalam Celsius
            lblCondition.Text = data.current.condition.text; // Kondisi cuaca (text)
            lblFeelsLike.Text = $"Feels like: {data.current.feelslike_c}°C"; // Suhu yang dirasakan

            // Tampilkan data detail cuaca
            lblUVValue.Text = data.current.uv.ToString(); // Indeks UV
            lblHumidityValue.Text = $"{data.current.humidity}%"; // Kelembaban
            lblPressureValue.Text = $"{data.current.pressure_mb} mb"; // Tekanan udara
            lblCloudValue.Text = $"{data.current.cloud}%"; // Persentase awan
            lblWindValue.Text = $"{data.current.wind_kph} km/h\n{data.current.wind_dir}"; // Kecepatan dan arah angin
            lblPrecipValue.Text = $"{data.current.precip_mm} mm"; // Curah hujan

            // Tampilkan data kualitas udara jika tersedia
            if (data.current.air_quality != null)
            {
                // Tampilkan indeks kualitas udara dengan deskripsi
                lblAQValue.Text = $"Air Quality \n{GetAQIDescription(data.current.air_quality.usepaindex)}";
                // Tampilkan PM 2.5 (partikel halus)
                lblPM25Value.Text = $"PM 2.5: {data.current.air_quality.pm2_5:F1} µg/m³";
                // Tampilkan PM 10 (partikel kasar)
                lblPM10Value.Text = $"PM10: {data.current.air_quality.pm10:F1} µg/m³";
                // Tampilkan Carbon Monoxide
                lblCOValue.Text = $"CO: {data.current.air_quality.co:F1} µg/m³";
                // Tampilkan Ozone
                lblO3Value.Text = $"O3: {data.current.air_quality.o3:F1} µg/m³";
            }

            // Load icon cuaca utama berdasarkan kode cuaca dan waktu (siang/malam)
            LocalIcon(data.current.condition.code, data.current.is_day == 1, pictureBoxWeather);

            // Tampilkan forecast 3 hari jika data tersedia
            if (data.forecast.forecastday != null && data.forecast.forecastday.Count >= 3)
            {
                DisplayForecastDay(data.forecast.forecastday[0], lblDay1Date, lblDay1Temp, lblDay1Condition, picDay1);
                DisplayForecastDay(data.forecast.forecastday[1], lblDay2Date, lblDay2Temp, lblDay2Condition, picDay2);
                DisplayForecastDay(data.forecast.forecastday[2], lblDay3Date, lblDay3Temp, lblDay3Condition, picDay3);
            }

            // Load icon kelembaban
            picHumidity.LoadAsync(Path.Combine(Application.StartupPath, "icons", "humidity.png"));

            // Load icon tekanan udara (tinggi/rendah berdasarkan nilai tekanan standar 1013.25 mb)
            if (data.current.pressure_mb >= 1013.25)
            {
                picPressure.LoadAsync(Path.Combine(Application.StartupPath, "icons", "pressure-high.png"));
            }
            else
            {
                picPressure.LoadAsync(Path.Combine(Application.StartupPath, "icons", "pressure-low.png"));
            }

            // Load icon angin (alert jika kecepatan >= 21 km/h)
            if (data.current.wind_kph >= 21)
            {
                picWind.LoadAsync(Path.Combine(Application.StartupPath, "icons", "wind-alert.png"));
            }
            else
            {
                picWind.LoadAsync(Path.Combine(Application.StartupPath, "icons", "wind.png"));
            }

            // Load icon curah hujan (banyak tetes jika >= 11 mm)
            if (data.current.precip_mm >= 11)
            {
                picPrecip.LoadAsync(Path.Combine(Application.StartupPath, "icons", "raindrops.png"));
            }
            else
            {
                picPrecip.LoadAsync(Path.Combine(Application.StartupPath, "icons", "raindrop.png"));
            }

            // Load icon UV berdasarkan indeks UV (0-11+)
            int uvIndex = (int)Math.Floor(data.current.uv);
            uvIndex = Math.Min(uvIndex, 11); // Cap maksimal di 11

            string iconName = uvIndex >= 1
                ? $"uv-index-{uvIndex}.png"
                : "not-available.png";

            picUV.LoadAsync(Path.Combine(Application.StartupPath, "icons", iconName));

            // Load icon awan berdasarkan persentase awan
            if (data.current.cloud <= 50)
            {
                picCloud.LoadAsync(Path.Combine(Application.StartupPath, "icons", "mist.png"));
            }
            else
            {
                picCloud.LoadAsync(Path.Combine(Application.StartupPath, "icons", "overcast.png"));
            }

            // Update status berhasil dengan warna hijau
            lblStatus.Text = "Weather data loaded successfully!";
            lblStatus.ForeColor = Color.FromArgb(150, 255, 150);
        }

        // Fungsi untuk menampilkan data forecast per hari
        private void DisplayForecastDay(Forecastday forecastDay, Label lblDate, Label lblTemp, Label lblCondition, PictureBox pictureBox)
        {
            // Validasi: cek apakah data forecast null
            if (forecastDay == null) return;

            // Parse tanggal dan format menjadi "Day, Month DD" (contoh: Mon, Jan 15)
            DateTime date = DateTime.Parse(forecastDay.date);
            lblDate.Text = date.ToString("ddd, MMM dd", CultureInfo.InvariantCulture);

            // Tampilkan suhu maksimal dan minimal (format: XX°/YY°)
            lblTemp.Text = $"{forecastDay.day.maxtemp_c:F0}°/{forecastDay.day.mintemp_c:F0}°";
            // Tampilkan kondisi cuaca
            lblCondition.Text = forecastDay.day.condition.text;

            // Load icon cuaca dari folder lokal (selalu gunakan icon siang untuk forecast)
            LocalIcon(forecastDay.day.condition.code, true, pictureBox);
        }

        // Fungsi untuk memuat icon cuaca dari folder lokal
        private void LocalIcon(int weatherCode, bool isDay, PictureBox pictureBox)
        {
            try
            {
                // Load icon menggunakan class WeatherIcon
                Image icon = WeatherIcon.LoadWeatherIcon(weatherCode, isDay);
                // Jika icon berhasil dimuat, set ke PictureBox
                if (icon != null)
                    pictureBox.Image = icon;
                else
                    pictureBox.Image = null; // Set null jika gagal
            }
            catch
            {
                // Jika terjadi error, set image null
                pictureBox.Image = null;
            }
        }

        // Fungsi untuk mendapatkan deskripsi kualitas udara berdasarkan indeks
        private string GetAQIDescription(int index)
        {
            return index switch
            {
                1 => "Good", // Baik
                2 => "Moderate", // Sedang
                3 => "Unhealthy for Sensitive Groups", // Tidak sehat untuk kelompok sensitif
                4 => "Unhealthy", // Tidak sehat
                5 => "Very Unhealthy", // Sangat tidak sehat
                6 => "Hazardous", // Berbahaya
                _ => "Not Available" // Tidak tersedia
            };
        }

        // Fungsi untuk membersihkan/mereset tampilan cuaca
        private void ClearWeatherDisplay()
        {
            // Reset semua label menjadi "-"
            lblCity.Text = "-";
            lblCountry.Text = "-";
            lblTemp.Text = "-";
            lblCondition.Text = "-";
            lblFeelsLike.Text = "Feels like: -";
            lblUVValue.Text = "-";
            lblHumidityValue.Text = "-";
            lblPressureValue.Text = "-";
            lblCloudValue.Text = "-";
            lblWindValue.Text = "-";
            lblPrecipValue.Text = "-";
            lblAQValue.Text = "-";
            lblPM25Value.Text = "PM 2.5: -";
            lblPM10Value.Text = "PM10: -";
            lblCOValue.Text = "CO: -";
            lblO3Value.Text = "O3: -";

            // Hapus semua gambar icon
            pictureBoxWeather.Image = null;
            picDay1.Image = null;
            picDay2.Image = null;
            picDay3.Image = null;

            // Reset label forecast 5 hari menjadi "N/A"
            lblDay1Date.Text = "N/A";
            lblDay1Temp.Text = "N/A";
            lblDay1Condition.Text = "N/A";

            lblDay2Date.Text = "N/A";
            lblDay2Temp.Text = "N/A";
            lblDay2Condition.Text = "N/A";

            lblDay3Date.Text = "N/A";
            lblDay3Temp.Text = "N/A";
            lblDay3Condition.Text = "N/A";

        }

        // Fungsi ketika user menekan tombol di textbox
        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cek jika tombol yang ditekan adalah Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Trigger event btnSearch_Click (sama seperti klik tombol search)
                btnSearch_Click(sender, e);
                // Set Handled = true agar tidak ada "beep" sound
                e.Handled = true;
            }
        }

        // Override Fungsi OnFormClosing untuk cleanup saat form ditutup
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Dispose HttpClient untuk membebaskan resource
            httpClient?.Dispose();
            // Panggil base Fungsi
            base.OnFormClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
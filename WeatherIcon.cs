using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeatherApp;

namespace WeatherApp
{
    public static class WeatherIcon
    {
        // Dictionary untuk menyimpan mapping antara kode cuaca dengan nama icon
        private static Dictionary<int, string> weatherCodeToIcon = new Dictionary<int, string>();
        // Variable untuk menyimpan path folder icon
        private static string iconFolder = Path.Combine(Application.StartupPath, "icons");

        // Constructor static yang dipanggil pertama kali saat class digunakan
        static WeatherIcon()
        {
            InitializeWeatherCodes();
        }

        // Fungsi untuk mengatur path folder icon
        public static void IconFolder(string folderPath)
        {
            iconFolder = folderPath;
        }

        // Fungsi untuk menginisialisasi mapping kode cuaca ke nama icon
        private static void InitializeWeatherCodes()
        {
            weatherCodeToIcon = new Dictionary<int, string>
            {
                // Cerah/Berawan
                { 1000, "clear-day" },
                
                // Cerah Berawan
                { 1003, "partly-cloudy-day" },
                
                // Berawan
                { 1006, "cloudy" },
                { 1009, "overcast" },
                
                // Kabut
                { 1030, "mist" },
                { 1135, "fog" },
                { 1147, "fog" },
                
                // Gerimis
                { 1063, "drizzle" },
                { 1150, "drizzle" },
                { 1153, "drizzle" },
                { 1168, "sleet" },
                { 1171, "sleet" },
                
                // Hujan
                { 1180, "rain" },
                { 1183, "rain" },
                { 1186, "rain" },
                { 1189, "rain" },
                { 1192, "rain" },
                { 1195, "rain" },
                { 1198, "sleet" },
                { 1201, "sleet" },
                { 1240, "rain" },
                { 1243, "rain" },
                { 1246, "rain" },
                
                // Salju
                { 1066, "snow" },
                { 1069, "sleet" },
                { 1072, "sleet" },
                { 1114, "snow" },
                { 1117, "snow" },
                { 1204, "sleet" },
                { 1207, "sleet" },
                { 1210, "snow" },
                { 1213, "snow" },
                { 1216, "snow" },
                { 1219, "snow" },
                { 1222, "snow" },
                { 1225, "snow" },
                { 1237, "hail" },
                { 1249, "sleet" },
                { 1252, "sleet" },
                { 1255, "snow" },
                { 1258, "snow" },
                { 1261, "hail" },
                { 1264, "hail" },
                
                // Badai Petir
                { 1087, "thunderstorms-day" },
                { 1273, "thunderstorms-day-rain" },
                { 1276, "thunderstorms-rain" },
                { 1279, "thunderstorms-day-snow" },
                { 1282, "thunderstorms-snow" }
            };
        }

        // Fungsi untuk memuat icon cuaca berdasarkan kode cuaca dan waktu (siang/malam)
        public static Image LoadWeatherIcon(int weatherCode, bool isDay)
        {
            try
            {
                // Dapatkan nama icon berdasarkan kode cuaca dan waktu
                string iconName = GetIconName(weatherCode, isDay);
                // Gabungkan path folder dengan nama file icon
                string iconPath = Path.Combine(iconFolder, $"{iconName}.png");

                // Cek apakah file icon ada
                if (File.Exists(iconPath))
                {
                    // Buka file icon dan buat copy bitmap-nya
                    using (var originalImage = Image.FromFile(iconPath))
                    {
                        return new Bitmap(originalImage);
                    }
                }
                else
                {
                    // Tulis pesan debug jika icon tidak ditemukan
                    System.Diagnostics.Debug.WriteLine($"Icon not found: {iconPath}");
                    return null!;
                }
            }
            catch (Exception ex)
            {
                // Tangkap error dan tulis pesan debug
                System.Diagnostics.Debug.WriteLine($"Error loading icon: {ex.Message}");
                return null!;
            }
        }

        // Fungsi untuk memuat icon cuaca dengan ukuran custom (resize)
        public static Image LoadWeatherIcon(int weatherCode, bool isDay, int width, int height)
        {
            try
            {
                // Muat icon asli terlebih dahulu
                Image originalIcon = LoadWeatherIcon(weatherCode, isDay);
                if (originalIcon == null) return null!;

                // Buat bitmap baru dengan ukuran yang diinginkan
                Bitmap resizedIcon = new Bitmap(width, height);
                using (Graphics g = Graphics.FromImage(resizedIcon))
                {
                    // Gunakan interpolasi berkualitas tinggi untuk hasil resize yang bagus
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    // Gambar icon asli ke bitmap baru dengan ukuran baru
                    g.DrawImage(originalIcon, 0, 0, width, height);
                }

                // Hapus icon asli dari memory untuk menghemat resource
                originalIcon.Dispose();
                return resizedIcon;
            }
            catch (Exception ex)
            {
                // Tangkap error dan tulis pesan debug
                System.Diagnostics.Debug.WriteLine($"Error resizing icon: {ex.Message}");
                return null!;
            }
        }

        // Fungsi private untuk mendapatkan nama icon berdasarkan kode cuaca dan waktu
        private static string GetIconName(int weatherCode, bool isDay)
        {
            string iconName;

            // Cari nama icon dari dictionary berdasarkan kode cuaca
            if (!weatherCodeToIcon.TryGetValue(weatherCode, out iconName!))
            {
                // Jika kode cuaca tidak ditemukan, gunakan icon default
                System.Diagnostics.Debug.WriteLine($"⚠️ Weather code {weatherCode} NOT FOUND in mapping! Using default.");
                iconName = isDay ? "clear-day" : "clear-night";
            }
            else
            {
                // Tulis pesan debug jika mapping berhasil ditemukan
                System.Diagnostics.Debug.WriteLine($"✓ Weather code {weatherCode} mapped to: {iconName}");
            }

            // Ganti icon siang dengan icon malam jika waktu adalah malam
            if (!isDay)
            {
                if (weatherCode == 1000) // Cerah
                {
                    iconName = "clear-night";
                }
                else if (weatherCode == 1003) // Cerah Berawan
                {
                    iconName = "partly-cloudy-night";
                }
                else if (weatherCode == 1087) // Badai Petir
                {
                    iconName = "thunderstorms-night";
                }
                else if (weatherCode == 1273) // Badai Petir dengan Hujan
                {
                    iconName = "thunderstorms-night-rain";
                }
                else if (weatherCode == 1279) // Badai Petir dengan Salju
                {
                    iconName = "thunderstorms-night-snow";
                }
                else if (iconName.Contains("-day"))
                {
                    // Ganti semua icon yang mengandung "-day" menjadi "-night"
                    iconName = iconName.Replace("-day", "-night");
                }
            }

            return iconName;
        }

        // Fungsi untuk mendapatkan daftar icon yang diperlukan untuk didownload
        public static List<string> GetRequiredIcons()
        {
            return new List<string>
            {
                // Icon untuk siang hari
                "clear-day.png",
                "partly-cloudy-day.png",
                "cloudy.png",
                "overcast.png",
                "mist.png",
                "fog.png",
                "drizzle.png",
                "rain.png",
                "snow.png",
                "sleet.png",
                "hail.png",
                "thunderstorms-day.png",
                "thunderstorms-day-rain.png",
                "thunderstorms-day-snow.png",
                "thunderstorms-rain.png",
                "thunderstorms-snow.png",
                
                // Icon untuk malam hari
                "clear-night.png",
                "partly-cloudy-night.png",
                "thunderstorms-night.png",
                "thunderstorms-night-rain.png",
                "thunderstorms-night-snow.png"
            };
        }

        // Fungsi untuk mengecek apakah icon tersedia di folder
        public static bool IsIconAvailable(int weatherCode, bool isDay)
        {
            // Dapatkan nama icon
            string iconName = GetIconName(weatherCode, isDay);
            // Gabungkan path folder dengan nama file
            string iconPath = Path.Combine(iconFolder, $"{iconName}.png");
            // Return true jika file ada, false jika tidak ada
            return File.Exists(iconPath);
        }

        // Fungsi untuk mendapatkan path icon berdasarkan deskripsi kondisi cuaca
        public static string GetIconPath(string condition)
        {
            // Ubah kondisi menjadi huruf kecil untuk pencocokan yang lebih mudah
            condition = condition.ToLower();
            string iconName = "not-available.png"; // icon default

            // Cek kondisi cuaca dan tentukan icon yang sesuai
            if (condition.Contains("sunny") || condition.Contains("clear"))
                iconName = "day-clear.png";
            else if (condition.Contains("cloud"))
                iconName = "cloudy.png";
            else if (condition.Contains("rain"))
                iconName = "rain.png";
            else if (condition.Contains("thunder"))
                iconName = "thunderstorms.png";
            else if (condition.Contains("snow"))
                iconName = "snow.png";
            else if (condition.Contains("mist") || condition.Contains("fog"))
                iconName = "fog.png";

            // Gabungkan path folder dengan nama icon
            return Path.Combine(Application.StartupPath, "Icons");
        }

        // Deskripsi cuaca dalam Bahasa Inggris
        public static string GetWeatherDescription(int weatherCode)
        {
            // Dictionary untuk menyimpan deskripsi cuaca dalam Bahasa Inggris
            var descriptions = new Dictionary<int, string>
            {
                { 1000, "Clear" },
                { 1003, "Partly Cloudy" },
                { 1006, "Cloudy" },
                { 1009, "Overcast" },
                { 1030, "Mist" },
                { 1063, "Possible Rain" },
                { 1135, "Fog" },
                { 1147, "Freezing Fog" },
                { 1150, "Light Drizzle" },
                { 1153, "Light Drizzle" },
                { 1180, "Light Rain" },
                { 1183, "Light Rain" },
                { 1186, "Moderate Rain" },
                { 1189, "Moderate Rain" },
                { 1192, "Heavy Rain" },
                { 1195, "Heavy Rain" },
                { 1087, "Thunderstorm" },
                { 1210, "Light Snow" },
                { 1213, "Light Snow" },
                { 1219, "Moderate Snow" },
                { 1225, "Heavy Snow" },
                { 1237, "Hail" },
                { 1273, "Thunder Rain" },
                { 1276, "Heavy Thunder Rain" }
            };

            // Return deskripsi jika kode cuaca ditemukan, jika tidak return "Unknown"
            return descriptions.ContainsKey(weatherCode)
                ? descriptions[weatherCode]
                : "Unknown";
        }
    }
}
using Newtonsoft.Json;
using System.Drawing.Imaging;
using WeatherApp;

namespace WeatherApp
{
    // Class untuk merepresentasikan data kualitas udara
    public class AirQuality
    {
        public required object co { get; set; } // Carbon Monoxide (Karbon Monoksida)
        public required object no2 { get; set; } // Nitrogen Dioxide (Nitrogen Dioksida)
        public required object o3 { get; set; } // Ozone (Ozon)
        public required object so2 { get; set; } // Sulfur Dioxide (Sulfur Dioksida)
        public required object pm2_5 { get; set; } // Particulate Matter 2.5 (Partikel halus 2.5 mikron)
        public required object pm10 { get; set; } // Particulate Matter 10 (Partikel 10 mikron)

        // Indeks kualitas udara US EPA dengan mapping JSON property
        [JsonProperty("us-epa-index")]
        public required int usepaindex { get; set; }

        // Indeks kualitas udara UK DEFRA dengan mapping JSON property
        [JsonProperty("gb-defra-index")]
        public required int gbdefraindex { get; set; }
    }

    // Class untuk merepresentasikan kondisi cuaca
    public class Condition
    {
        public required string text { get; set; } // Deskripsi kondisi cuaca dalam teks (contoh: "Sunny", "Rainy")
        public required string icon { get; set; } // URL icon cuaca dari API
        public required int code { get; set; } // Kode numerik kondisi cuaca (untuk mapping icon lokal)
    }

    // Class untuk merepresentasikan data cuaca saat ini (current weather)
    public class Current
    {
        public required object last_updated_epoch { get; set; } // Waktu update terakhir dalam format epoch/unix timestamp
        public required string last_updated { get; set; } // Waktu update terakhir dalam format string readable
        public required object temp_c { get; set; } // Suhu dalam Celsius
        public required object temp_f { get; set; } // Suhu dalam Fahrenheit
        public required int is_day { get; set; } // Indikator siang/malam (1 = siang, 0 = malam)
        public required Condition condition { get; set; } // Object kondisi cuaca
        public required object wind_mph { get; set; } // Kecepatan angin dalam miles per hour
        public required double wind_kph { get; set; } // Kecepatan angin dalam kilometer per hour
        public required object wind_degree { get; set; } // Arah angin dalam derajat
        public required string wind_dir { get; set; } // Arah angin dalam teks (contoh: "N", "SE", "SW")
        public required double pressure_mb { get; set; } // Tekanan udara dalam millibar
        public required double pressure_in { get; set; } // Tekanan udara dalam inches
        public required double precip_mm { get; set; } // Curah hujan dalam millimeter
        public required double precip_in { get; set; } // Curah hujan dalam inches
        public required double humidity { get; set; } // Kelembaban udara dalam persen
        public required double cloud { get; set; } // Persentase tutupan awan
        public required double feelslike_c { get; set; } // Suhu yang dirasakan dalam Celsius
        public required double feelslike_f { get; set; } // Suhu yang dirasakan dalam Fahrenheit
        public required double vis_km { get; set; } // Jarak pandang/visibility dalam kilometer
        public required double vis_miles { get; set; } // Jarak pandang/visibility dalam miles
        public required double uv { get; set; } // Indeks UV (ultraviolet)
        public required double gust_mph { get; set; } // Kecepatan hembusan angin maksimal dalam miles per hour
        public required object gust_kph { get; set; } // Kecepatan hembusan angin maksimal dalam kilometer per hour
        public required AirQuality air_quality { get; set; } // Object data kualitas udara
    }

    // Class untuk merepresentasikan data lokasi
    public class Location
    {
        public required string name { get; set; } // Nama kota/lokasi
        public required string region { get; set; } // Nama region/provinsi/state
        public required string country { get; set; } // Nama negara
        public required object lat { get; set; } // Koordinat latitude (garis lintang)
        public required object lon { get; set; } // Koordinat longitude (garis bujur)
        public required string tz_id { get; set; } // Timezone ID (contoh: "Asia/Jakarta")
        public required object localtime_epoch { get; set; } // Waktu lokal dalam format epoch
        public required string localtime { get; set; } // Waktu lokal dalam format string
    }

    // Class untuk merepresentasikan data forecast/ramalan cuaca
    public class Forecast
    {
        public required List<Forecastday> forecastday { get; set; } // List/daftar ramalan cuaca per hari
    }

    // Class untuk merepresentasikan data ramalan cuaca per hari
    public class Forecastday
    {
        public required string date { get; set; } // Tanggal ramalan dalam format string (YYYY-MM-DD)
        public required int date_epoch { get; set; } // Tanggal ramalan dalam format epoch
        public required Day day { get; set; } // Object data cuaca untuk hari tersebut
    }

    // Class untuk merepresentasikan detail cuaca harian
    public class Day
    {
        public required double maxtemp_c { get; set; } // Suhu maksimal dalam Celsius
        public required double maxtemp_f { get; set; } // Suhu maksimal dalam Fahrenheit
        public required double mintemp_c { get; set; } // Suhu minimal dalam Celsius
        public required double mintemp_f { get; set; } // Suhu minimal dalam Fahrenheit
        public required double avgtemp_c { get; set; } // Suhu rata-rata dalam Celsius
        public required double avgtemp_f { get; set; } // Suhu rata-rata dalam Fahrenheit
        public required double maxwind_mph { get; set; } // Kecepatan angin maksimal dalam miles per hour
        public required double maxwind_kph { get; set; } // Kecepatan angin maksimal dalam kilometer per hour
        public required double totalprecip_mm { get; set; } // Total curah hujan dalam millimeter
        public required double totalprecip_in { get; set; } // Total curah hujan dalam inches
        public required double avgvis_km { get; set; } // Rata-rata jarak pandang dalam kilometer
        public required double avgvis_miles { get; set; } // Rata-rata jarak pandang dalam miles
        public required int avghumidity { get; set; } // Rata-rata kelembaban dalam persen
        public required int daily_will_it_rain { get; set; } // Indikator apakah akan hujan (1 = ya, 0 = tidak)
        public required int daily_chance_of_rain { get; set; } // Persentase kemungkinan hujan
        public required int daily_will_it_snow { get; set; } // Indikator apakah akan turun salju (1 = ya, 0 = tidak)
        public required int daily_chance_of_snow { get; set; } // Persentase kemungkinan salju
        public required Condition condition { get; set; } // Object kondisi cuaca
        public required double uv { get; set; } // Indeks UV
    }

    // Class Root sebagai container utama untuk semua data response dari API
    public class Root
    {
        public required Location location { get; set; } // Data lokasi
        public required Current current { get; set; } // Data cuaca saat ini
        public required Forecast forecast { get; set; } // Data ramalan cuaca
        public required object alert { get; set; } // Data alert/peringatan cuaca (jika ada)
    }
}
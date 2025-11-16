# 🌤️ WeatherApp

> A modern, feature-rich desktop weather application delivering real-time weather data and forecasts worldwide.

[![Platform](https://img.shields.io/badge/Platform-Windows-blue.svg)](https://www.microsoft.com/windows)
[![Framework](https://img.shields.io/badge/.NET-Windows%20Forms-512BD4.svg)](https://dotnet.microsoft.com/)
[![API](https://img.shields.io/badge/API-WeatherAPI-00C851.svg)](https://www.weatherapi.com/)

---

## ✨ Features

### 🌡️ Real-Time Weather Data
- **Current Temperature** - Accurate readings in Celsius with "feels like" temperature
- **Weather Conditions** - Comprehensive status updates (clear, cloudy, rainy, snowy, etc.)
- **Location Intelligence** - Search any city worldwide with instant results
- **Last Updated** - Timestamp showing data freshness

### 📊 Detailed Weather Metrics
| Metric | Description |
|--------|-------------|
| **UV Index** | 0-11+ scale with visual indicators for sun safety |
| **Humidity** | Relative humidity percentage |
| **Pressure** | Atmospheric pressure (mb) with high/low alerts |
| **Wind** | Speed (km/h) + direction with storm warnings (≥21 km/h) |
| **Precipitation** | Rainfall intensity (mm) with heavy rain indicators (≥11 mm) |
| **Cloud Cover** | Percentage-based coverage with adaptive icons |

### 🌫️ Air Quality Index (AQI)
Real-time air pollution monitoring with **6-tier classification system**:
- ✅ **Good** - Safe for everyone
- 🟡 **Moderate** - Acceptable quality
- 🟠 **Unhealthy for Sensitive Groups** - At-risk individuals should limit exposure
- 🔴 **Unhealthy** - Everyone may experience effects
- 🟣 **Very Unhealthy** - Health alert conditions
- ⚫ **Hazardous** - Emergency conditions

**Pollutant Tracking:**
- PM 2.5 (fine particles)
- PM 10 (coarse particles)
- Carbon Monoxide (CO)
- Ozone (O₃)

### 📅 3-Day Forecast
- Daily high/low temperature predictions
- Weather condition outlook
- Dynamic weather icons
- Formatted date display (e.g., "Mon, Jan 15")

### 🎨 Smart Visual System
- **30+ Weather Icons** - Comprehensive icon library covering all conditions
- **Day/Night Mode** - Automatic icon switching based on local time
- **Conditional Alerts** - Visual warnings for:
  - High/low atmospheric pressure
  - Strong winds
  - Heavy precipitation
  - Extreme UV levels
- **Adaptive UI** - Icons change based on real-time conditions

---

## 🖼️ Screenshots

### Main Interface
> *Clean, intuitive design with all weather data at a glance*

### Dynamic Icons
> *Weather icons automatically adapt to conditions and time of day*

---

## 🚀 Getting Started

### Prerequisites
- Windows OS (10/11)
- .NET Framework 8+
- Internet connection for API access

### Installation

1. **Clone the repository**
```bash
   git clone https://github.com/yourusername/WeatherApp.git
```

2. **Open in Visual Studio**
```
   Open WeatherApp.sln
```

3. **Configure API Key**
   - Get your free API key from [WeatherAPI.com](https://www.weatherapi.com/)
   - Add to `Form1.cs`:
```csharp
   private const string API_KEY = "your_api_key_here";
```

4. **Build & Run**
   - Press `F5` or click Start
   - Enter a city name and explore!

---

## 🛠️ Technology Stack

### Core Technologies
- **C# .NET** - Primary programming language
- **Windows Forms** - GUI framework
- **WeatherAPI** - Real-time weather data provider
- **Newtonsoft.Json** - JSON deserialization

### Programming Concepts
- ✅ Async/Await programming for smooth UI
- ✅ RESTful API integration
- ✅ Object-oriented design patterns
- ✅ Event-driven architecture
- ✅ Exception handling & validation
- ✅ Resource management
- ✅ Dictionary-based data mapping

---

## 📂 Project Structure
```
WeatherApp/
├── Form1.cs              # Main application UI & logic
├── Root.cs               # Weather data models
│   ├── Root
│   ├── Location
│   ├── Current
│   ├── Forecast
│   ├── Forecastday
│   ├── Day
│   ├── Condition
│   └── AirQuality
├── WeatherIcon.cs        # Icon management system
└── icons/                # Weather icon assets
    ├── clear-day.png
    ├── clear-night.png
    ├── rain.png
    └── ... (30+ icons)
```

---

## 🎯 Key Highlights

### Performance
- **Non-blocking Operations** - Async API calls prevent UI freezing
- **Efficient Caching** - Smart icon loading and management
- **Error Recovery** - Graceful handling of network issues

### User Experience
- **Quick Search** - Enter key support for instant results
- **Loading Feedback** - Real-time status updates
- **Visual Clarity** - Color-coded messages and organized layouts
- **Intuitive Design** - No learning curve required

### Code Quality
- Clean, well-documented code
- Separation of concerns
- Reusable components
- Proper resource disposal

---

## 📡 API Integration

### Endpoint
```
http://api.weatherapi.com/v1/forecast.json
```

### Parameters
| Parameter | Value | Description |
|-----------|-------|-------------|
| `key` | API Key | Authentication |
| `q` | City name | Location query |
| `days` | 5 | Forecast range |
| `aqi` | yes | Air quality data |
| `alerts` | yes | Weather alerts |

---

## 🙏 Acknowledgments

- [WeatherAPI](https://www.weatherapi.com/) - Reliable weather data provider
- [Newtonsoft.Json](https://www.newtonsoft.com/json) - JSON framework
- Weather icons inspired by modern design principles

---

## Preview
    ┌────────────────────────────────────────────┐
    │                 WEATHER                    │
    │  [ Search Box ]        [ Search ]          │
    ├────────────────────────────────────────────┤
    │            CURRENT WEATHER                 │
    │  [Icon]  City, Country                     │
    │  Temp°C — Sunny                            │
    │  Feels like: Temp                          │
    ├────────────────────────────────────────────┤
    ┌────────────┐  ┌────────────┐  ┌────────────┐
    │     Day    │  │     Day    │  │     Day    │
    │    [Icon]  │  │    [Icon]  │  │    [Icon]  │
    │max/min temp│  │max/min temp│  │max/min temp│
    │    Desc    │  │    Desc    │  │     Desc   │
    └────────────┘  └────────────┘  └────────────┘
    ├────────────────────────────────────────────┤
    │  UV                 │ Humidity             │
    ├─────────────────────┼──────────────────────┤
    │ Pressure            │ Cloud                │
    ├─────────────────────┼──────────────────────┤
    │ Wind                │ Precip               │
    ├────────────────────────────────────────────┤
    │              Air Quality                   │
    ├────────────────────────────────────────────┤
    │      PM2.5, PM10, CO, O₃                   │
    └────────────────────────────────────────────┘

---

<div align="center">

**⭐ Star this repository if you find it helpful!**

Made with ❤️ using C# and Windows Forms

</div>

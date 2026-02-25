\# 🌦️ C# Hava Durumu Uygulaması (WeatherApp)



Bu proje, \*\*OpenWeatherMap API\*\* kullanarak canlı hava durumu verilerini çeken, asenkron yapıda geliştirilmiş bir C# konsol uygulamasıdır. Java ve Spring Boot tecrübelerimi modern C# yapılarıyla birleştirdiğim bir çalışmadır.



\## 🚀 Özellikler

\* \*\*Asenkron Programlama:\*\* `HttpClient` ile `async/await` yapısı kullanılarak ağ istekleri yönetilir.

\* \*\*JSON Serialization:\*\* API'den gelen veriler `System.Text.Json` ile C# modellerine (DTO) dönüştürülür.

\* \*\*Hata Yönetimi:\*\* Geçersiz şehir girişleri ve bağlantı sorunları try-catch bloklarıyla yönetilir.

\* \*\*Modern C# Syntax:\*\* String interpolation, auto-properties ve relational patterns (switch) kullanılmıştır.



\## 🛠️ Kullanılan Teknolojiler

\* .NET 8.0 / C#

\* OpenWeatherMap API

\* System.Text.Json



\## 📖 Nasıl Çalıştırılır?

1\. OpenWeatherMap üzerinden bir API anahtarı edinin.

2\. `WeatherService.cs` dosyasındaki `\_apiKey` alanına anahtarınızı ekleyin.

3\. Projeyi derleyin ve çalıştırın.


using System;
using System.Threading.Tasks; 
using WeatherApp.Models;      
using WeatherApp.Services;  

namespace WeatherApp
{
    internal class Program
    {
        // void yerine async Task oldu
        static async Task Main(string[] args)
        {
            Console.WriteLine("CANLI HAVA DURUMU MERKEZİNE HOS GELDİNİZ");

            WeatherService havaDurumuServisi = new WeatherService();

            
            while (true)
            {
                Console.Write("\nHava durumunu öğrenmek istediğiniz şehri giriniz (Çıkmak için 0): ");
                string sehir = Console.ReadLine();

                if (sehir == "0")
                {
                    Console.WriteLine("Çıkış yapılıyor. İyi günler dileriz!");
                    break;
                }

                // null enter kontrol
                if (string.IsNullOrWhiteSpace(sehir))
                {
                    Console.WriteLine("Lütfen geçerli bir şehir adı giriniz!");
                    continue;
                }

                Console.WriteLine("İnternete bağlanılıyor, lütfen bekleyiniz...");

                // await bekleyis
                WeatherResponse sonuc = await havaDurumuServisi.GetWeatherAsync(sehir);

                //200OK veri
                if (sonuc != null)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green; ;
                    Console.WriteLine($"Şehir: {sonuc.SehirAdi.ToUpper()}");
                    Console.WriteLine($"Gerçek Sıcaklık: {sonuc.AnaVeriler.Sicaklik:0.00} °C");
                    Console.WriteLine($"Hissedilen Sıcaklık: {sonuc.AnaVeriler.Hissedilen:0.00} °C");
                    Console.ResetColor();
                    Console.WriteLine("--------------------------------------------------");
                }
            }
        }
    }
}
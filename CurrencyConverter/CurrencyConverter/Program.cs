using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arvutaUuesti = true;
            while (arvutaUuesti)
            {
                Console.WriteLine("See on valuutakalkulaator.");
                Console.WriteLine("Hetkel arvutab valuutakalkulator kursse: EUR, USD, AUD, GBP, RUB, THB, SEK.");

                Console.WriteLine("Millist kurssi soovite vahetada?");
                string kasutajaKurss = Console.ReadLine().ToUpper();

                Console.WriteLine("Millist valuutakurssi soovite saada?");
                string vahetusKurss = Console.ReadLine().ToUpper();
                Console.WriteLine("Palun sisestage kogus: ");
                double kogus = double.Parse(Console.ReadLine());
                string kurss = $"{kasutajaKurss}_{vahetusKurss}";

                string url = ($"https://free.currconv.com/api/v7/convert?q={kurss}&compact=ultra&apiKey=5439fdf57a4bb4bb95e5");
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";

                var webResponse = request.GetResponse();
                var webStream = webResponse.GetResponseStream();

                using (var responseReader = new StreamReader(webStream))
                {
                    var response = responseReader.ReadToEnd();
                    CurrencyData currencyData = JsonConvert.DeserializeObject<CurrencyData>(response);

                    if (kurss == "EUR_USD")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {Math.Round(currencyData.EUR_USD * kogus),2} {vahetusKurss}.");
                    }
                    else if (kurss =="EUR_AUD")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.EUR_AUD * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "EUR_GBP")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.EUR_GBP * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "EUR_RUB")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.EUR_RUB * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "EUR_THB")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.EUR_THB * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "EUR_SEK")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.EUR_SEK * kogus} {vahetusKurss}.");
                    }


                    else if (kurss == "USD_EUR")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.USD_EUR * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "USD_AUD")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.USD_AUD * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "USD_GBP")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.USD_GBP * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "USD_RUB")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.USD_RUB * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "USD_THB")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.USD_THB * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "USD_SEK")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.USD_SEK * kogus} {vahetusKurss}.");
                    }


                    else if (kurss == "AUD_EUR")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.AUD_EUR * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "AUD_USD")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.AUD_USD * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "AUD_GBP")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.AUD_GBP * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "AUD_RUB")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.AUD_RUB * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "AUD_THB")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.AUD_THB* kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "AUD_SEK")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.AUD_SEK * kogus} {vahetusKurss}.");
                    }


                    else if (kurss == "GBP_EUR")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.GBD_EUR * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "GBP_AUD")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.GBD_AUD * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "GBP_USD")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.GBD_USD * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "GBP_RUB")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.GBD_RUB * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "GBP_THB")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.GBD_THB * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "GBP_SEK")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.GBD_SEK * kogus} {vahetusKurss}.");
                    }


                    else if (kurss == "RUB_EUR")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.RUB_EUR * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "RUB_AUD")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.RUB_AUD * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "RUB_GBP")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.RUB_GBP * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "RUB_USD")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.RUB_USD * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "RUB_THB")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.RUB_THB * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "RUB_SEK")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.RUB_SEK * kogus} {vahetusKurss}.");
                    }


                    else if (kurss == "THB_EUR")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.THB_EUR * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "THB_AUD")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.THB_AUD * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "THB_GBP")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.THB_GBP * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "THB_RUB")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.THB_RUB * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "THB_USD")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.THB_USD * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "THB_SEK")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.THB_SEK * kogus} {vahetusKurss}.");
                    }


                    else if (kurss == "SEK_EUR")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.SEK_EUR * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "SEK_AUD")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.SEK_AUD * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "SEK_GBP")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.SEK_GBP * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "SEK_RUB")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.SEK_RUB * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "SEK_USD")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.SEK_USD * kogus} {vahetusKurss}.");
                    }
                    else if (kurss == "SEK_THB")
                    {
                        Console.WriteLine($"Hetkel saate {kogus} {kasutajaKurss} eest - {currencyData.SEK_THB * kogus} {vahetusKurss}.");
                    }
                }
                Console.WriteLine("Kas soovite veel arvutada kurssi? JAH/EI");
                string vastus = Console.ReadLine().ToUpper();

                if (vastus == "JAH")
                {
                    arvutaUuesti = true;
                    Console.Clear();
                }
                else if (vastus == "EI")
                {
                    arvutaUuesti = false;
                }
                else
                {
                    Console.WriteLine("Sisestasid valesti!");
                }
            }
        }
    }
}

using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string [] args)
        {
            TimeSpan(); 

        }

        static void TimeSpan()
        {
            Console.Clear();

            var timeSpan = new TimeSpan(); // O timeSpan é bom para fazer cálculo de horas 
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1); // ele é bem sensível e pode colocar muitas informações nele
            Console.WriteLine(timeSpanNanosegundos);

            var timeSpanHoraminuto = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraminuto);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilisegundo = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilisegundo);

                // O timeSpan é utilizado em cálculos de datas
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

        }

        static void utcDate(){
            var utcdate = DateTime.UtcNow; // é aplicado para aplicações globalizadas
            Console.WriteLine(utcdate);
            Console.WriteLine(utcdate.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcdate, timezoneAustralia);
            Console.WriteLine(horaAustralia);

           
        } static void timezones(){
             
            var br = new CultureInfo("pt-br");
            Console.WriteLine(DateTime.Now.ToString("D", br));

             var utcdate = DateTime.UtcNow;
             var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
              Console.Clear();
             Console.WriteLine(timezone.Id);
            Console.WriteLine(timezone);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcdate, timezone));
            Console.WriteLine("------------"); 
            }
            
            
        }  static void data(){
            var data = DateTime.Now; // Para ter a data de hoje é utilizado o DateTime.Now
           var data1 = new DateTime(2022, 9, 6, 12, 59, 11); 
// o DateTime é uma struct, e sempre irá retornar com valores.E ele retorna com uma estrutura de data, mês e ano.
          var formatada = String.Format("{0:u}", data); // Y = ano, M = mês, d = dia, h = hora, m = minuto, s = segundo, T = um short datetime compactado
          if (data.Date == DateTime.Now.Date){
        Console.WriteLine("É igual");
          }
          Console.WriteLine(data.AddDays(12)); // Posso obter separado colocando o data.Year,Month e etc.
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortOdev
{
    class Program
    {
        static void Main(string[] args)
        {
         Tools yeni = new();
         Console.WriteLine("Ödev Projesine Hoşgeldiniz...");
         Console.WriteLine("-----------------------------");
         Console.WriteLine("Ödev Listesi: ");
         Console.WriteLine("1. Ödev : 1 ");
         Console.WriteLine("2. Ödev : 2 ");
         Console.WriteLine("3. Ödev : 3 ");
         Console.WriteLine("4. Ödev : 4 ");
         Console.WriteLine("Çıkmak için : X ");
         
        while (true)
        {
            Console.Write("Görmek İstediğiniz ödevin numarasını tuşlayın: ");
            string secim = Console.ReadLine();
            switch (secim)
         {
             case  "1":
             Console.WriteLine("Ödev 1 : Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.");
                yeni.CiftYazdır();
                break;
            case  "2":
                Console.WriteLine("Ödev 2 : Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.");
                yeni.EsitveBolunur();
                break;
            case  "3":
                Console.WriteLine("Ödev 3 : Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.");
                yeni.KelimeTersten();
                break;
            case  "4":
                Console.WriteLine("Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.");
                yeni.HarfveKelime();
                break;
            case "X":
            case "x":
                Environment.Exit(0);
                break;
             default:
                Console.WriteLine("Hatalı tuşladınız tekrar deneyin.");
                break;
         }
        }
        
         

        }   
    }
}
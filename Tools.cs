using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortOdev
{
    public class Tools
    {
        public void CiftYazdır()
        {
            Console.WriteLine("Kaç Adet Sayı Girmek İstiyorsunuz: ");
            int giris = int.Parse(Console.ReadLine());
            int[] dizi = new int[giris];
            for (int i = 0; i <= giris-1; i++)
            {
                Console.Write("{0}. Sayıyı giriniz: ",i+1);
                int sayi = int.Parse(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    dizi[i] = sayi;
                    
                }
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Girdiğiniz Sayılar Arasından Çift Olanlar: ");
            foreach (var item in dizi)
            {
                if (item != 0)
                {
                    Console.Write(item + "-");
                    
                } 
            }
            Console.Write(" ");
            Console.WriteLine("-------------------------------------------");
            
        }
        
        public void EsitveBolunur()
        {
            Console.WriteLine("-------------------------------------------");
            Console.Write("Bir sayı girinizi: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Bir sayı daha giriniz: ");
            int m = int.Parse(Console.ReadLine());
            int[] dizi = new int[999];
            for (int i = 0; i <n; i++)
            {
                Console.Write("{0}. Sayıyı giriniz: ",i+1);
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == m || sayi % m == 0)
                {
                    dizi[i] = sayi;
                }

            }
            Console.WriteLine("-------------------------------------------");
            foreach (var item in dizi)
            {
                if (item > 0)
                {
                    Console.Write(item + "-");
                    
                } 
            }
            Console.Write(" ");
            Console.WriteLine("-------------------------------------------");
        }
        public void KelimeTersten()
        {
            Console.Write("Bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());
            string[] dizi = new string[sayi];
            for (int i = 0; i < sayi; i++)
            {
                Console.Write("{0}. kelimeyi giriniz: ",i+1);
                dizi[i] = Console.ReadLine().ToString();
            }
            Console.Write(" ");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Girdiğiniz kelimelerin en sondan en ilke sıralanışı: ");
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("-------------------------------------------");
        }
        public void HarfveKelime()
        {
            Console.Write("Bir Cümle Giriniz: ");
            string cumle = Console.ReadLine().ToString();
            int sayac = 1;
            foreach (char item in cumle)
            {
                if(item != ' ')
                {
                    sayac++;
                }
            }
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Girdiğiniz Cümle Toplam " + kelimeler.Length + " kelimden oluşmaktadır.");
            Console.WriteLine("Aynı zamanda toplam harf sayısı: " + sayac );



        }
          
    }
}
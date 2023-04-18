using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enviroment.Exıt_metodunun_kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 sayıya 4 işlemi uygulayan programı başlatmak istermisiniz [E/H] ");
            string cevap =  Console.ReadLine();
            Console.Clear();
            Console.ReadLine();
            if (cevap == "E")
              
            
            Console.WriteLine("uygulama Başlatılıyor"); 

            else if (cevap == "H")
            Environment.Exit(0);

            Console.ReadLine();
            Console.Clear();
            int x, y, t, z, toplam , cıkarma , carpma, ort;
            Console.WriteLine("Lütfen 1.Sayıyı Giriniz");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2.Sayıyı Giriniz");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 3.Sayıyı Giriniz");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 4.Sayıyı Giriniz");
            z = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.Clear();

            toplam = x + y + t + z;
            cıkarma = x - y - t - z;
            carpma = x * y * t * z;
            ort = toplam / 4;

            Console.WriteLine("Toplamları :" + toplam);
            Console.WriteLine("Farkları :" + cıkarma);
            Console.WriteLine("Çarpımları :" + carpma);
            Console.WriteLine("Aritmetik ortalaması :" + ort);
            Console.ReadKey();
            
            
           

        }
    }
}

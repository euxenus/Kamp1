using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazilim gelistirici yetistirme kampı";
            string kurs2 = "proglamlamaya baslangıc icin temel kurs";
            string kurs3 = "java";
            //bu tip verileri array (dizi)lerde tutululr.kolaylık olsun diye:)

            string[] kurslar = new string[] { "yazilim gelistirici yetistirme kampı",
                "proglamlamaya baslangıc icin temel kurs" , "java" };
            
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            //foreach ***dizi temelli yapıları tek tek dönmeye(dolaşmaya ) yararr.
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            
            
            
            
            
            Console.WriteLine("sayfaSonu");
        }
    }
}

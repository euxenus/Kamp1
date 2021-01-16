using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "c#";
            kurs1.egitmen = "emirn";
            kurs1.izlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "java";
            kurs2.egitmen = "kerem";
            kurs2.izlenmeOrani = 658;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "phyton";
            kurs3.egitmen = "zırto";
            kurs3.izlenmeOrani = 88;

            // Console.WriteLine(kurs1.kursAdi + ":" + kurs1.egitmen);



            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var gurs in kurslar)
            {
                Console.WriteLine(gurs.kursAdi);
            }











         
        }
    }
    class kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }





    }


}

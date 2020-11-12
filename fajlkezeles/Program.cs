using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fajlkezeles
{
    struct tit
    {
        public string Kategoria;
        public int Tulelo;
        public int Eltunt;
    }

    class Program
    {
        static List<tit> titanic = new List<tit>();
     
        static void Main(string[] args)
        {
            F01();
            F02();
            F03();
            F04();
            F05();
            F06();
            F07();
            Console.ReadLine();
        }

        private static void F07()
        {
            
        }

        private static void F06()
        {
            List<string> eltunArany = new List<string>();
            foreach (var e in titanic)
            {
                if ((e.Tulelo+e.Eltunt) * 0.6 <= e.Eltunt)
                {
                    eltunArany.Add(e.Kategoria);
                }
            }
            Console.WriteLine("6.feladat:\n");
            for (int i = 0; i < eltunArany.Count; i++)
            {
                Console.Write($"{eltunArany[i]} \n");
            }
           
        }

        private static void F05()
        {
           
        }

        private static void F04()
        {
            
        }

        private static void F03()
        {
            int ossz = 0;
            foreach (var e in titanic)
            {
                ossz = ossz + e.Tulelo + e.Eltunt;
            }
            Console.WriteLine($"3. feladat: {ossz} fő");
        }

        private static void F02()
        {
            Console.WriteLine($"2. feladat: {titanic.Count} db");
        }

        private static void F01()
        {
            var sr = new StreamReader("titanic.txt");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');

                titanic.Add(new tit()
                {
                    Kategoria = sor[0],
                    Tulelo = int.Parse(sor[1]),
                    Eltunt = int.Parse(sor[2]),
                });
            }
            sr.Close();
        }
    }
}

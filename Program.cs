using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak25._10._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite nekakav tekst");
            string s1 = Console.ReadLine(); 
            string sVelika = s1.ToUpper();
            string sMala = s1.ToLower();
            string sPrvaTri = s1.Substring(0, 3);
            string sZadnjaPet = s1.Substring(s1.Length-5);
            string s3 = s1.Substring(8, s1.Length - 11);
            Console.WriteLine(sVelika);
            Console.WriteLine(sMala);   
            Console.WriteLine(sPrvaTri);
            Console.WriteLine(sZadnjaPet);
            

            if (s1.Length > 11)
            {
                Console.WriteLine(s3);
            }
            else
            {
                Console.WriteLine("Tekst nema dovoljno slova");
            }


            Console.ReadKey();
        }
    }
}

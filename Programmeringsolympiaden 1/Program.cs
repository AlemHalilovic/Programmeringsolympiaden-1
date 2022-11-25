using System;
namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Morötter = 40;
            Console.WriteLine("Skriv in Torstid");
            string Torstid = Console.ReadLine();
            Console.WriteLine("Skriv in antal morötter tor har ätit");
            string AntalMT = Console.ReadLine();
            int TorsNyaTid = int.Parse(Console.ReadLine());
            int TorsNyaAntal = int.Parse(Console.ReadLine());
            Console.WriteLine(TorsNyaAntal / TorsNyaTid);



        }
    }
}
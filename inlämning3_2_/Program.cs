using System;
namespace inlämning3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Hej! Vi söker ny personal på vårat företag.");
                Console.WriteLine("Har du gått ut gymnasiet? ( j / n )");
                string gåttut = Console.ReadLine();
                Console.WriteLine("Hur gammal är du?");
                int ålder = int.Parse(Console.ReadLine());

                if (gåttut == "j" && ålder < 22)
                {
                    Console.WriteLine("Vill vill gärna anställa dig!");
                }
                else
                {
                    Console.WriteLine("Vi söker tyvärr annan personal just nu.");
                }
            }
        }
    }
}
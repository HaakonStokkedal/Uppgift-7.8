using System.Collections.Immutable;

namespace Uppgift_7._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många koder vill du skriva in?");
            int antal = int.Parse(Console.ReadLine());
            Dictionary<char, char> map = new Dictionary<char, char>();

            Console.WriteLine($"Skriv in {antal} koder här:");

            for (int i = 0; i < antal; i++)
            {
                var input = Console.ReadLine().ToLower().Split(' ');
                map.Add(input[0][0], input[1][0]);
                map.Add(input[0].ToUpper()[0], input[1].ToUpper()[0]);
            }
            Console.WriteLine("Skriv in ditt hemliga meddelande här:");
            string hemligt = Console.ReadLine();

            Console.WriteLine(AvKodaMeddelande(map, hemligt));

        }

        static string AvKodaMeddelande(Dictionary<char, char> koder, string hemligt)
        {
            var avKodad = hemligt;
            bool fortsätt = true;
            while (fortsätt)
            {
                fortsätt = false;
                foreach (var key in koder.Keys)
                {
                    avKodad = avKodad.Replace(key, koder[key]);
                }

                foreach (var key in koder.Keys)
                {
                    if (avKodad.Contains(key))
                    {
                        fortsätt = true;
                    }
                }
            }

            return avKodad;
        }

      
    }
}
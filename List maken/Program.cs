using System;
using System.Collections.Generic;

namespace List_maken
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Family = new List<string>() { "Healey", "Sil" };

            Family.Add("Gael");
            Family.Add("Patricia");
            Family.Add("Myrto");
            Family.Add("Tadzio");

            Family.Remove("Gael");
            Family.Remove("Healey");
            Family.Remove("Sil");

            foreach (string name in Family)
            {
                Console.WriteLine(Family);
            }
            Console.ReadLine();
        }
    }
}

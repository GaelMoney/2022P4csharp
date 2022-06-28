using System;
using System.IO;

namespace StringOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringText = File.ReadAllText(@"C:\Users\gaelg\Documents\Periode 4 Eerste jaar\2022P4csharp\StringOpdracht\stringsplit.txt");
            string[] text = stringText.Split(':', ',');

            foreach (string tekst in text)
            {
                Console.WriteLine(tekst);
            }
        }
    }
}
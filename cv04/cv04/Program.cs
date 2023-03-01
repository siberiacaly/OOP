using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv04
{
    class Program
    {
        static void Main(string[] args)
        {
            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
 + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
 + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
 + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
 + "posledni veta!  ";
            StringStatistics s = new StringStatistics(testovaciText);
            Console.WriteLine(testovaciText + "\n");
            Console.WriteLine("Number of words: {0}", s.NumberOfWords());
            Console.WriteLine("Number of rows: {0}", s.NumberOfRow());
            Console.WriteLine("Number of sentences: {0}", s.NumberOfSentences());
            Console.WriteLine("Longest word: {0}", s.PrintArrayList(s.LongestWord()));
            Console.WriteLine("Shortest word: {0}", s.PrintArrayList(s.ShortestWord()));
            Console.WriteLine("Most common word: {0}", s.PrintArrayList(s.MostCommonWord()));
            Console.WriteLine("Alphabetically sorted words: {0}", s.PrintArrayList(s.SortedArray()));
        }
    }
}
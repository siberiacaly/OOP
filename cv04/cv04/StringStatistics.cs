using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv04
{
    public class StringStatistics
    {
        public string Text { get; set; }

        public StringStatistics(string text)
        {
            this.Text = text;
        }


        public int NumberOfWords() //pocet slov
        {
            char[] delimiterChars = { ' ', '\n' };
            int words = Text.Split(delimiterChars).Length;
            return words;
        }


        public int NumberOfRow() //pocet radku
        {
            int row = Text.Split('\n').Length;
            return row;
        }

        public int NumberOfSentences() //pocet vet
        {
            char[] delimiterChars = { '.', '?', '!' };
            string text = Text.Replace("\n", "").Replace(" ", "");
            string[] row = text.Split(delimiterChars);
            int counter = 0;
            for (int i = 0; i < row.Length - 2; i++)
            {
                if (i == 0 && Char.IsUpper(row[i][0]))
                {
                    counter++;
                }
                if (Char.IsUpper(row[i + 1][0]))
                {
                    counter++;
                }
            }
            return counter;
        }

        public ArrayList LongestWord() //nejdelsi slovo
        {
            ArrayList longestWord = new ArrayList();
            string text = Text.Replace("\n", " ").Replace("!", "").Replace("?", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "");
            string[] words = text.Split(' ');
            int biggestLength = 0;

            foreach (var word in words)
            {
                if (word.Length > biggestLength)
                {
                    biggestLength = word.Length;
                    longestWord.Clear();
                    longestWord.Add(word);
                }
                else if (word.Length == biggestLength)
                {
                    longestWord.Add(word);
                }
            }
            return longestWord;
        }

        public ArrayList ShortestWord() //nejkratsi slovo
        {
            ArrayList longestWord = new ArrayList();
            string text = Text.Replace("\n", " ").Replace("!", "").Replace("?", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "");
            string[] words = text.Split(' ');
            int shortestLength = int.MaxValue;

            foreach (var word in words)
            {
                if (word.Length < shortestLength)
                {
                    shortestLength = word.Length;
                    longestWord.Clear();
                    longestWord.Add(word);
                }
                else if (word.Length == shortestLength)
                {
                    longestWord.Add(word);
                }
            }
            return longestWord;
        }

        public ArrayList MostCommonWord() //nejvic uzivane slovo
        {
            var dict = new Dictionary<string, int>();
            ArrayList commonWord = new ArrayList();
            string text = Text.Replace("\n", " ").Replace("!", "").Replace("?", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "");
            string[] words = text.Split(' ');
            int ocurencies = 0;
            foreach (var thing in words)
            {
                if (dict.ContainsKey(thing))
                {
                    dict[thing]++;
                }
                else
                {
                    dict.Add(thing, 1);
                }
            }
            foreach (var key in dict)
            {
                if (key.Value > ocurencies)
                {
                    ocurencies = key.Value;
                    commonWord.Clear();
                    commonWord.Add(key.Key);
                }
                else if (key.Value == ocurencies)
                {
                    commonWord.Add(key.Key);
                }
            }
            return commonWord;
        }

        public ArrayList SortedArray() //slova podle abecedy
        {
            ArrayList wordList = new ArrayList();
            string text = Text.Replace("\n", " ").Replace("!", "").Replace("?", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "");
            string[] words = text.Split(' ');
            foreach (var thing in words)
            {
                wordList.Add(thing);
            }
            wordList.Sort();
            return wordList;
        }

        public StringBuilder PrintArrayList(ArrayList arrlist) //Vrací stringbuilder se slovy(thing) z arraylistu a kazde slovo je oddelene carkou
        {
            StringBuilder text = new StringBuilder();
            if (arrlist.Count == 1)
            {
                text.Append(arrlist[0]);
            }
            else
            {
                foreach (var item in arrlist)
                {
                    text.Append(item).Append(", ");
                }
            }
            return text;
        }



        public override string ToString()
        {
            return this.Text;
        }

    }
}




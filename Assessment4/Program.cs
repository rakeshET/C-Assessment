using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter string:");
            string text = Console.ReadLine();
            Console.WriteLine("You entered :"+text);

            // WORDS COUNT

            int wordsCount = text.Trim(' ').Split(' ').Length;
            Console.WriteLine("Words Count :{0}",wordsCount);

            //SENTENCE COUNT

            int sentenceCount = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("Sentence Count :{0}",sentenceCount);

            //CHARACTERS COUNT
            int charCount = text.Length;
            Console.WriteLine("Characters Count :{0}", charCount);

            //LONGEST WORD
            string[] words = text.Split(new[] { " " }, StringSplitOptions.None);

            string longestWord = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    longestWord = s;
                    ctr = s.Length;
                }
            }
                
            Console.WriteLine(longestWord);
        }
    }
}


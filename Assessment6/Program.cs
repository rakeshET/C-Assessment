using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Assessment6
{
    internal class Program
    {
        static void Main()
        {
            string pathName = @"C:\Users\Rakesh\Desktop\myFile.txt";


            string textToAdd = "Added Text :- Example text in file \n";

            FileStream fs = null;

            //CREATE NEW FILE
            try
            {
                fs = new FileStream(pathName, FileMode.CreateNew);
                    Console.WriteLine("File is created.");

                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(textToAdd);
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
            //APPEND NEW LINE 
            string appendText = "Appended text :-This is extra text" + Environment.NewLine;
            File.AppendAllText(pathName, appendText);

            //READ FROM FILE
            string readText = File.ReadAllText(pathName);
            Console.WriteLine(readText);


            // WORDS COUNT

            int wordsCount = readText.Trim(' ').Split(' ').Length;
            Console.WriteLine("Words Count :{0}", wordsCount);

            //SENTENCE COUNT

            int sentenceCount = readText.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("Sentence Count :{0}", sentenceCount);

            //CHARACTERS COUNT
            int charCount = readText.Length;
            Console.WriteLine("Characters Count :{0}", charCount);

            //LONGEST WORD
            string[] words = readText.Split(new[] { " " }, StringSplitOptions.None);

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

            Console.WriteLine("Longest word: {0}",longestWord);
        }
    }
    }





using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public class Program
    {
             
        static void Main(string[] args){
            List<int> studentGrade = new List<int>();
            Console.WriteLine("Add grade: "); 
            for (int i = 0; i < 6; i++) 
            {
               Console.WriteLine($"{i + 1}:Enter next grade");
               var ListInput = int.Parse(Console.ReadLine()); 
               studentGrade.Add(ListInput);


            }
            Console.Write("Students Grade :");
            Console.WriteLine(String.Join(",", studentGrade));

            double average = studentGrade.Average();
            Console.WriteLine("Average = :{0}",average);

            double heighestGrade = studentGrade.Max();
            Console.WriteLine("Heighest Grade = :{0}", heighestGrade);

            double lowestGrade = studentGrade.Min();
            Console.WriteLine("Lowest grade Grade = :{0}", lowestGrade);

            studentGrade.FindAll(x => x > 50);
            foreach (var pass in studentGrade)
            {
                Console.Write("Passed :");
                Console.WriteLine(pass);
            }
            studentGrade.FindAll(x => x < 50);
            foreach (var failed in studentGrade)
            {
                Console.Write("Failed :");
                Console.WriteLine( failed);
            }

        }
    }   
}

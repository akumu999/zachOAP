using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace zacheeeet
{
    class Program
    {    
        static void Main(string[] args)
        {
            string[] sr1 = File.ReadAllLines("file1.txt");
            List<string> list = new List<string>();
            foreach(var sr2 in sr1)
            {
                list.Add(sr2);
            }
            var orderedSurnames = from b in list
                                  orderby b descending
                                  select b;

            int i = 0;
            foreach(string b in orderedSurnames)
            {
                Console.WriteLine(b);
                sr1[i] = b;
                i++;
            }

                Console.WriteLine("Выберите студента");
                int f = Convert.ToInt32(Console.ReadLine());
                f = f - 1;
                Console.WriteLine("Выбран студент " + sr1[f]);
                string[] numbers = sr1[f].Split(new char[] { '+', '(', ')', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int[] exams = new int[3];
                exams[0] = Convert.ToInt32(numbers[6]);
                exams[1] = Convert.ToInt32(numbers[7]);
                exams[2] = Convert.ToInt32(numbers[8]);

                var max = exams.Max();
                Console.WriteLine("Максимальный балл: "+ max);
            

        }
    }
}

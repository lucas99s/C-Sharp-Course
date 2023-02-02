using System;
using System.Collections.Generic;

namespace _9_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Anna");
            list.Add("Bob");
            list.Add("Lucas");
            list.Add("Renata");
            list.Add("Roberta");
            list.Add("Carlo");

            Print(list); 

            Console.WriteLine();
            list.Insert(2, "Inserido");
            Print(list);

            Console.WriteLine();
            Console.WriteLine("List count: " + list.Count);

            Console.WriteLine();
            string s1 = list.Find(x => x[0] == 'R'); //encontre a primeira string x que tenha o primeiro caractere que comece com R.
            Console.WriteLine("First 'R': " + s1);

            string s2 = list.FindLast(x => x[0] == 'R');
            Console.WriteLine("Last 'R': " + s2);

            int s3 = list.FindIndex(x => x[0] == 'R');
            Console.WriteLine("First position 'R': " + s3);
            
            int s4 = list.FindLastIndex(x => x[0] == 'R');
            Console.WriteLine("Last position 'R': " + s4);

            Console.WriteLine();

            List<string> filtered = list.FindAll(x => x.Length == 5);
            Console.WriteLine("Filtered names that has 5 characters: ");
            Print(filtered);

            Console.WriteLine();
            Console.WriteLine("Remove Anna: ");
            list.Remove("Anna");
            Print(list);

            Console.WriteLine();
            Console.WriteLine("Remove names that start with R: ");
            list.RemoveAll(x => x[0] == 'R');
            Print(list);


            Console.WriteLine();
            Console.WriteLine("Remove at position 2 ");
            list.RemoveAt(1);
            Print(list);


            Console.WriteLine();
            Console.WriteLine("Remove range: ");
            list.RemoveRange(1, 2);
            Print(list);
        }

        static void Print(List<string> list)
        {
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

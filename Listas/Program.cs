using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Listas
{
    class program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("João");
            list.Add("Matheus");
            list.Add("Duda");
            list.Insert(2, "Meire");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(list.Count);

            string s1 = list.Find(x => x[0] == 'D');
            Console.WriteLine("Primeira letra 'D': " + s1);

            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s3);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Fisrt position 'A':" + pos1);
            
        }
    }
}
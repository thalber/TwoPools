using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoPools
{
    internal class Program
    {

        internal static void Main()
        {
            //TwoPools<string, string> test = new(new[] { "a", "b", "c" }, new[] { "d", "e", "f" });
            //test.EstablishLink("a", "d");
            //test.EstablishLink("a", "e");
            //foreach (var r in test.IndexFromLeft("a")) Console.WriteLine(r);

            TwoPools<int, int> test2 = new();
            for (int i = 0; i < 50; i++) test2.InsertLeft(i);
            for (int j = 0; j < 50; j++) test2.InsertRight(j);
            for (var i = 0; i < 50; i++)
            {
                for (var j = i; j < 50; j++)
                {
                    test2.EstablishLink(i, j);
                }
            }

            foreach (var x in test2.IndexFromLeft(40)) Console.WriteLine(x);
            Console.WriteLine("- - - -");
            test2.RemoveRight(45);
            test2.RemoveLink(40, 47);
            foreach (var x in test2.IndexFromLeft(40)) Console.WriteLine(x);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tests;
internal class Program
{

    internal static void Main()
    {
        TwoPools<int, int> 
            test1 = new(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }),
            test2 = new(new[] {1, 2, 3}, new[] { 7, 8, 9 });
        test1.AddLink(1, 4);
        test2.AddLink(1, 8);
        var test3 = TwoPools<int, int>.Stitch(test1, test2);
        Console.WriteLine(test3);
    }
}


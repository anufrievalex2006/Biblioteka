using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static Wardrobe w = new();
        static Readroom r = new();
        static void Main(string[] args)
        {
            Visitor vis = new();
            vis.putClothes(w);
            r.giveBook(vis);
            Console.Read();
        }
    }
}

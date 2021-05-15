using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Wardrobe : Lib
    {
        private readonly Random r = new();
        public void getClothes(Visitor v)
        {
            if (visits.Count < 100) v.num = r.Next(0, 100);
            else throw new Exception("больше нет мест в гардеробе.");
        }
        public void giveClothes(Visitor v)
        {
            visits.Remove(v);
        }
    }
}

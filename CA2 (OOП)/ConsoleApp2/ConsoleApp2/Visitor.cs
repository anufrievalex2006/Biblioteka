using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Visitor
    {
        public bool cloth = false; // сдана ли одежда
        private readonly Random r = new();
        public int num;
        public void putClothes(Wardrobe w)
        {
            cloth = true;
            w.getClothes(this);
        }
        public void getClothes(Wardrobe w)
        {
            cloth = false;
            w.giveClothes(this);
        }
    }
}

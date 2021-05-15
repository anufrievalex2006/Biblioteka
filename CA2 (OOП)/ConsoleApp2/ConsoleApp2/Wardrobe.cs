using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Wardrobe
    {
        public int num = 0;
        public int[] m = new int[100];
        private void fillM(int[] v) // заполнение массива номерков
        {
            for (int i = 0; i < v.Length; i++)
                v[i] = (i + 1);
        }
        public void giveNum(Visitor v)
        {
            if (v.cloth == false && num < m.Length)
            {
                v.cloth = true;
                while (!m.Contains(num))
                    num++;
                m = m.Where(t => t != num).ToArray();
                Console.Write("Посетитель сдал одежду.");
            }
            else Console.Write("стоп, он же сдал одежду ._.");
        }
    }
}

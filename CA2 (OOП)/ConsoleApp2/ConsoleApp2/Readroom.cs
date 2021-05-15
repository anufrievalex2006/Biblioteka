using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Readroom : Lib
    {
        public void giveBook(Visitor v)
        {
            if (v.cloth == true)
            {
                visits.Add(v);
                isBookGiven = true;
            }
        }
    }
}

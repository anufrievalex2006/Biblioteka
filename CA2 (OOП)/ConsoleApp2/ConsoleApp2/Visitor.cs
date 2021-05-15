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
        public string name;
        public Visitor(string name)
        {
            this.name = name;
        }
    }
}

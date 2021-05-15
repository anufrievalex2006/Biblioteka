using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Readroom
    {
        public List<string> names = new(100);
        public void giveBook(Visitor v)
        {
            if (v.cloth == true)
            {
                try
                {
                    names.Add(v.name);
                }
                catch
                {
                    throw new Exception("В читательном зале нет мест.");
                }
            }
        }
    }
}

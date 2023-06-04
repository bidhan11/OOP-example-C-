using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface Apple
    {
        void color();
    }
    interface Mango
    {
        void taste();
    }
    class MultipleInheritace : Apple, Mango
    {
        public void color()
        {
            Console.WriteLine("Color");
        }
    }

}

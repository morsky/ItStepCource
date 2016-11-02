using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverflowCheck
{
    class Program
    {
        static void Main()
        {
            int myInteger = int.MaxValue;

            checked
            {
                myInteger++;
            }
        }
    }
}

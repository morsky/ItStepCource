using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2
{
    class ImplementList
    {
        static void Main(string[] args)
        {
            List opit = new List();
            opit.Add(1);
            opit.Add(2);
            opit.Add(3);
            opit.Add(4);
            opit.Add(5);
            opit.Add(6);
            opit.Add(7);
            opit.Add(8);
            opit.Add(9);
            opit.Add(10);

            opit.Remove(2);

            opit.Get(0);
            opit.Get(1);
            opit.Get(2);
            opit.Get(3);
            opit.Get(4);
            opit.Get(5);
            opit.Get(6);
            opit.Get(7);
            opit.Get(8);
            opit.Get(9);
            opit.Get(10);
            opit.Get(11);
            opit.Get(12);
            opit.Get(13);
            opit.Get(14);
            opit.Get(15);

            //GenericList<int> opit = new GenericList<int>();
            //opit.Add(1);
            //opit.Add(2);

            //GenericList<string> test = new GenericList<string>();
            //test.Add("edno");
            //test.Add("dve");
            //test.Remove("dwe");
        }
    }
}
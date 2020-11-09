using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE_vjezba1
{
    class Program
    {
        static void Main(string[] args)
        {
            int br1 = 100; int br2 = -1000;
            char slov1 = 'a';
            float br3 = 3.123f;
            double br4 = 3.123456789;
            bool tocno=true;
            string rijec= "true";
            Console.Write("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
                br1, br2, slov1, br3, br4, tocno, rijec);
            Console.ReadKey();
        }
    }
}

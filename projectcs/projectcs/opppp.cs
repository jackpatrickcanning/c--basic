using System;
using System.Collections.Generic;
using System.Text;

namespace projectcs
{
    class opppp
    {
        public int A, B, C;
        public void message()
        {
            Console.Write("hola amigos mios, no odio a nadie");
            Console.Write("tenga un buen dia");
        }
        public void Add(int x,int y)
        {
            int Result = x + y;
            Console.Write("    result" +     Result);
        }
        public void Salslip(int sal)
        {
            float tax, net;
            if (sal >=2000)

            {
                tax = sal * 20 / 100;
            }
            else
            {
                tax = sal * 10 / 100;
            }
            net = sal - tax;

            Console.WriteLine("............");
            Console.WriteLine(" your sal is: " + sal);
            Console.WriteLine("tax calc is :" + tax);
            Console.WriteLine(" net sal is: + net");

        }
    }
}

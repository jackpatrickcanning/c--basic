using System;
using System.Collections.Generic;
using System.Text;

namespace thursdaypm
{
    class mathsbcs : mathacs
    {
        public void subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("The result os subtraction is:    " + result);
        }

        new public void add(int a, int b)
        {

            Console.WriteLine("the result is:  " + (a + b));
        }
    }
}
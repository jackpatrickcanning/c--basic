using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            int phy;
            int che;
            int mat;
            int total;
            float per;
            phy = 95;
            che = 80;
            mat = 100;
            total = phy + che + mat;
            per = total + 100 / 450;
            Console.Write("total MArks:");
            Console.WriteLine(total);
            Console.Write("Percentage: ");
            Console.WriteLine(per);
            Console.Write(5 / 2);
            Console.Read();

            if (per >= 60)
            {
                Console.Write(" you've passed bruh");
            }

            if (per < 60)
            {
                Console.Write("sorry bruh you failed");
            }
            Console.Read();
        }
    }
}

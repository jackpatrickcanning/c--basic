using System;

namespace ISTHURSDAYY
{
    class Program
    {
        static void Main(string[] args)
        {
            exam school = new exam();
            exam university = new exam();
         
            university.physics(99);
            university.chemistry(78);
            university.showresults();
            Console.Read();
        }
    }
}

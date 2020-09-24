using System;
using System.Collections.Generic;
using System.Text;

namespace ISTHURSDAYY
{
    class exam
    {
        private int phy, che, mat;
        private int maxmarks,passmarks;
        private  int invalidmarks, failed;
        public exam()
        {
            maxmarks = 100;
            passmarks = 50;
        }
        public exam(int M, int P)
        {
            maxmarks = M;
            passmarks =P;
        
        }
        public void physics(int p) { 
            if (p >= 0 && p <= maxmarks)
            {
                phy = p;
                if (p < passmarks) {
                    failed = 1;
                }
                
            }
            else
            {
                invalidmarks = -1;
                Console.WriteLine("invalid physics marks"+ maxmarks + "are the max marks");
            }
        }
        public void chemistry(int c)
        {
            if (c >= 0 && c <= maxmarks)
            {
                phy = c;
                if (c < passmarks) {
                    failed = 1;
                }


            }
            else
            {
                invalidmarks = -1;
                Console.WriteLine("invalid chemistry marks" + maxmarks + "are the max marks");
            }
        }
        public void maths(int m)
        {
            if (m >= 0 && m <= maxmarks)
            {
                phy = m;


            }
            else
            {
                Console.WriteLine("invalid maths marks" + maxmarks + "are the max marks");
            }
        }
        public void showresults()
        {
            float total, per;
            total = phy + che +mat;
            per = total * 100 / (maxmarks * 3);

            if (invalidmarks == 0) {
                if (failed == 0) 
                {
                    Console.WriteLine("Total Marks: " + total);
                    Console.WriteLine("Percentage: " + per);
                }
                else
                {
                    Console.Write("you have failed the exam");
                }
            }
        }

	}
    }


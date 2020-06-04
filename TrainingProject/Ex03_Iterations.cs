using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    public class Ex03_Iterations
    {

        public static void WhileDemo()
        {
            int i = 1;
            
            while(i<=5)
            {
                Console.WriteLine("the value of i :"+i);
                i = i+1;
            }

        }

        public static void DoWhileDemo()
        {
            int i = 1;
          do
            {
                Console.WriteLine("the value of i :" + i);
                i = i + 1;
            }while (i <= 5);

        }


        public static void ForDemo()
        {

            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("the value of i is: "+i);
            }
        }
    }
}

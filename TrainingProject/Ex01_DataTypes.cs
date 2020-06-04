using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.ClassesCore;

namespace TrainingProject
{
    public class Ex01_DataTypes
    {
        static string x;
        public static void Demo()
        {

            Car mycar = new Car();
            This isKool = new This();
            This isNotBad;

            x = "ssss";
            string name1 = " khan";
            Console.WriteLine("Assalamu alikum"); // this is my first program to run use ctrl+F5
            Console.WriteLine("wassalam " + name1);
            // this is how you comment

            /* this is 
             * another
             * way
             */

            byte b; // declaration
            b = 23; // initialisation
            int i = 10; // declaration and initialisation at the same time.
            long l = 239238;

            float f = 23.4545F;
            double d = 1212.88;


            double dd = 1;
            b = (byte)i; // explicit casting

            f = l; // implicit casting;
            char c = 'e';
            string s = "my name is khan";

            var i1 = 10;
            int i2 = 20;
            int sum;
            sum = i1 + i2;
            Console.WriteLine("sum is " + sum);

            int x1 = 51 % 2;
            Console.WriteLine(x1);
            string number = "500";
            string date1 = "12/02/2020";
            char num1 = 'z';
            int x2 = 5;

            int i100 = Convert.ToInt32(number); // this is called parsing.
            int x3 = x2 + i100;
            Console.WriteLine(x3);

            int @out = 121; // cannot use reserved words as variable.

            //== is for comparision
            // = is for assignment
            Console.WriteLine(x2 == 10);
            Console.WriteLine(x2 != 10);


        }

        public void m1()
        {
            x = "tttt";
        }
    }
}

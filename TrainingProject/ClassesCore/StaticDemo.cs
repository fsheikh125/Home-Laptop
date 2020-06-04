using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class StaticDemo
    {
        public static int i = 10;
        public int j = 10;

        static public void SMethod()
        {
            Console.WriteLine("this is a static method");
            i = 15;
            StaticDemo ss = new StaticDemo();
            ss.j = 77;
            //j = 19;
            //NSmethod(); //static method can access only static members and methods 
            //NOT nonstatic member and non static members
        }

        public void NSmethod()
        {
            i = 1000;
            j = 199;
            SMethod();

        }

    }
}

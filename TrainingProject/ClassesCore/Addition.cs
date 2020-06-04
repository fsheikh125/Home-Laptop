using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class Addition
    {
        
        public void add(int a, int b )
        {
            int sum = a + b;
            Console.WriteLine("Addition of two int : "+sum);
        }

        public void add(int a, int b, int c)
        {
            int sum = a + b+c;
            Console.WriteLine("Addition of three int : " + sum);
        }

        public void add( string s1, string s2)
        {

        }
        public void add(int zzz, int yyyy, double ssss)
        {

        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class Triangle : Shape
    {
        public override void Area(int d1, int d2)
        {
            double a = 0.5 * d1 * d2;
            Console.WriteLine("area of the triangle is " + a);
        }
    }
}

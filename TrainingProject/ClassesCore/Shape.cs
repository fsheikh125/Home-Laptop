using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public abstract class Shape
    {
        int dim1;

        public abstract void Area(int d1, int d2);


        
        public void Details()
        {
            Console.WriteLine("Shape details");
        }

    }
}

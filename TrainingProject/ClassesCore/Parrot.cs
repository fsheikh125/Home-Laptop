using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class Parrot : IBird, IJungle
    {
        public void bushes()
        {
            Console.WriteLine(  "Green bushes");
        }

        public void Eat()
        {
            Console.WriteLine("Parrot eats tomotoes");
        }

        public void Fly()
        {
            Console.WriteLine("Parrots fly 5 m high");
        }
    }
}

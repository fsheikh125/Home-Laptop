using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    public class Ex02_ControlStatements
    {

        

        public static void Demo()
        {
            int x = 5, y = 10;
            

            if (x<10)
            {
                Console.WriteLine("x is less than 10");
            }

            if(x<10 && y>100)
            {
                Console.WriteLine("The expression is true");
            }
            else
            {
                Console.WriteLine("The expression is FALSE");
            }


        }

        public static void NestedIfElseDemo()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            if (name == "Abdul")
            {
                Console.WriteLine("assalamu alikum "+name);
            }
            else if(name == "John")
            {
                Console.WriteLine("Good morning "+name);
            }
            else if (name == "Bhatti")
            {
                Console.WriteLine("Sasriya kaal "+ name);
            }
            else
            {
                Console.WriteLine("Hello");
            }

        }

        public static void SwitchDemo()
        {
           
            Console.Write("Enter Name: ");
            var name = Console.ReadLine();

          
            switch(name.ToLower())
            {

                case "abdul":
                       Console.WriteLine("assalamu alikum " + name);
                        break;
                    
                case "john":
                    Console.WriteLine("Good morning "+name);
                    break;
                case "jaspal":
                    Console.WriteLine("sasriyakal "+name);
                    break;
                default:
                    Console.WriteLine("Hello ji "+ name);
                    break;
                   

            }

        }

    }
}

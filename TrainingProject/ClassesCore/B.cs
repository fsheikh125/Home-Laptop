using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
   public class B : A
    {
        public string fname = "Muhammad";
       // public string sname = "Khan"; // to avoid  duplication
        public void Hobbies()
        {
            Console.WriteLine("Playing foot ball");
        }
        
        public void demoThisAndBase ()
        {
            Console.WriteLine("Demo of this and base ");
            this.Hobbies();
            base.Hobbies();
            
        }
        
    }
}

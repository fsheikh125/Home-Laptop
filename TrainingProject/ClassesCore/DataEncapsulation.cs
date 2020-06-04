using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class DataEncapsulation
    {
        private string name;


        public string Email { get; set; }

        
       
        
        
        public string Name
        {
            get { return name; }
            set { name = value; }

        }

       // behind the scenes

        public string getName()
        {
            return name;
        }

        public void setName(string _name)
        {
            name = _name;
        }

    }
}

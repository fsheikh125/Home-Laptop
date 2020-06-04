using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.Utilities
{
    public class Utils
    {

        public static string ReverseString(String mystr)
        {
            var reversedText = String.Concat(mystr.Reverse());
            return reversedText;
        }
        public static void writeToFile (string path, string txt)
        {

            File.WriteAllText(path, txt);
        }

    }
}

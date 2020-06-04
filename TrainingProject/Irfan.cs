using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining
{
    class Irfan
    {

        public string Reverse(string Text)
        {


            string bb = new string(Text.Reverse().ToArray());
            return bb;

        }

        public static int GetRandomNo1and10()

        {

            Random rnd = new Random();
            int month = rnd.Next(1, 11);
            return month;

        }

        public static int GenerateRandomNo4()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);

        }


        public static string GenerateNumber10()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 11; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;

        }



        public static void GetDirectory()
        {

            System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            var a = Assembly.GetEntryAssembly();
            var s = a.Location;
            var x = Path.GetDirectoryName(s);
            Console.WriteLine(x);
            // return  x;
        }
        public static void CreateDir(string location)
        {

        }

        public static string TimeDate()
        {


            var now = DateTime.Now;
            var formattedDate = now.ToString("dd-MM-yyyy HH mm ss");
            return formattedDate;

        }
        public static string RandomDate(int startYear = 2020, string outputDateFormat = "dd-MM-yyyy")
        {
            DateTime start = new DateTime(startYear, 1, 1);
            Random gen = new Random(Guid.NewGuid().GetHashCode());
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range)).ToString(outputDateFormat);
        }
    }
}

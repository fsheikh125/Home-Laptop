using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
    [Binding]
    public class Ex05_S2
    {
        //public static int  noOfitems;

        ShareStateObjects sso;
        public Ex05_S2(ShareStateObjects patapati)
        {
            sso = patapati;

        }

        [When(@"I add (.*) items in the basket")]
        public void WhenIAddItemsInTheBasket(int noofitemsfromstep)
        {
           
            sso.noOfitems = noofitemsfromstep;
        }
    }
}

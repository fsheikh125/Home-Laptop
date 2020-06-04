using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
 [Binding]
    public class Ex05_S1 
    {
        //public static int initial;

       ShareStateObjects sso;
          public Ex05_S1(ShareStateObjects chingchuu)
            {
            sso = chingchuu;

            }


        [Given(@"I have (.*) items in the basket")]
        public void GivenIHaveItemsInTheBasket(int initialvaluefromstep)
        {
           
            sso.initial = initialvaluefromstep;
        }

    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
    [Binding]
    class Ex05_S3
    {

        //public static int total;

        ShareStateObjects sso;
        public Ex05_S3(ShareStateObjects chingchuu)
        {
            sso = chingchuu;

        }


        [Then(@"I have (.*) items in the basket")]
        public void ThenIHaveItemsInTheBasket(int totalfromstep)
        {
            
            sso.total = sso.initial + sso.noOfitems;
            Assert.AreEqual(totalfromstep, sso.total);
        }

    }
}

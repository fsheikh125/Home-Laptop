using NUnit.Framework;
using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.L3_SeleniumCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{
    [Binding]
    class MyAccountPageSteps
    {

        ShareStateObjects sso;

        public MyAccountPageSteps(ShareStateObjects _sso)
        {
            this.sso = _sso;

        }

        [Then(@"I should be on my accounts page")]
        public void ThenIShouldBeOnMyAccountsPage()
        {
            bool MyAccountHeader = new MyAccountPage(sso).IsMyAccountHeaderDisplayed();
            Assert.IsTrue(MyAccountHeader);
        }      
        
    }
}

using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{
    [Binding]
       

    class AddProductToCartSteps
    {
        ShareStateObjects sso;
        public AddProductToCartSteps(ShareStateObjects _sso)
        {
            sso = _sso;
        }


        [Given(@"The user adds (.*) from the popular section")]
        public void GivenTheUserAddsBlouseFromThePopularSection(string p0)
        {
            ScenarioContext.Current.Pending();
        }





    }
}

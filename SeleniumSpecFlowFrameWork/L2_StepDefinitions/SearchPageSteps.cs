using OpenQA.Selenium;
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
    class SearchPageSteps
    {
        ShareStateObjects sso;

        public SearchPageSteps(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        [When(@"The user searches for Printed Summer Dress")]
        public void WhenTheUserSearchesForPrintedSummerDress(string p0)
        {
            SearchPage searchPage = new SearchPage(sso);
            searchPage.SearchDress(p0);
        }







    }
}

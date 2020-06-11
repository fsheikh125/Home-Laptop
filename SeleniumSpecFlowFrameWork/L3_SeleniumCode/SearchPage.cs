using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    class SearchPage
    {
        ShareStateObjects sso;
        By errorMessage_txt = By.LinkText("Printed Dress");

        public SearchPage(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        public void SearchDress(string dname)
        {
            sso.driver.FindElement(By.Id("search_query_top")).SendKeys(dname);
            sso.driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
        }

        public bool IsErrorMessageDisplayed()
        {
            var messageDisplayed = sso.driver.FindElement(errorMessage_txt).Displayed;
            return messageDisplayed;
        }

    }
}

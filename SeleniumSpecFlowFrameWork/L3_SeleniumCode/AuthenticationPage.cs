using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    public class AuthenticationPage
    {
        
        By Email_txt = By.Id("email");
        By Password_txt = By.Id("passwd");
        By Submit_btn = By.Id("SubmitLogin");
        By errorMessage_txt = By.XPath("//li[text()='Authentication failed.']");
        

        ShareStateObjects sso;

        public AuthenticationPage(ShareStateObjects _sso)
        {
            this.sso = _sso;
        }


        public void Login(string username, string password)
        {
            sso.driver.FindElement(Email_txt).SendKeys(username);
            sso.driver.FindElement(Password_txt).SendKeys(password);
            sso.driver.FindElement(Submit_btn).Click();
        }

        public void ClearEmailField()
        {
            sso.driver.FindElement(Email_txt).Clear();
        }

        public bool IsErrorMessageDisplayed()
        {
            var messageDisplayed = sso.driver.FindElement(errorMessage_txt).Displayed;
            return messageDisplayed;
        }

        
    }
}

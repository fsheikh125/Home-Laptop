using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    
    class RegisterNewUser
    {
        By RegEmail_txt = By.Id("email_create");
        By RegSubmit_btn = By.Id("SubmitCreate");
        By homeIcon_logo = By.XPath("//i[@class='icon-home']");
        ShareStateObjects sso;

        public RegisterNewUser(ShareStateObjects _sso)
        {
            this.sso = _sso;
        }

        public void RegisterAccount(string emailadd, string newdomain)
        {
            Random random = new Random();
            string randomNumber = random.Next(1, 999).ToString();

            sso.driver.FindElement(RegEmail_txt).SendKeys(emailadd + randomNumber + newdomain );
            sso.driver.FindElement(RegSubmit_btn).Click();
        }

        public void FillAccountDetails()
        {
            sso.driver.FindElement(By.XPath("//input[@name='id_gender']")).Click();
            sso.driver.FindElement(By.Id("customer_firstname")).SendKeys("Faizan");
            sso.driver.FindElement(By.Id("customer_lastname")).SendKeys("Sheikh");


            sso.driver.FindElement(By.Id("passwd")).SendKeys("Test1234");

            IWebElement date = sso.driver.FindElement(By.Id("days"));
            SelectElement ValueSelection1 = new SelectElement(date);
            ValueSelection1.SelectByValue("1");

            IWebElement month = sso.driver.FindElement(By.Id("months"));
            SelectElement ValueSelection2 = new SelectElement(month);
            ValueSelection2.SelectByValue("3");

            IWebElement year = sso.driver.FindElement(By.Id("years"));
            SelectElement ValueSelection3 = new SelectElement(year);
            ValueSelection3.SelectByValue("1983");

            //sso.driver.FindElement(By.Id("firstname")).SendKeys("Faizan");
            //sso.driver.FindElement(By.Id("lastname")).SendKeys("Sheikh");
            sso.driver.FindElement(By.Id("address1")).SendKeys("3 Southview");
            sso.driver.FindElement(By.Id("city")).SendKeys("Dewbury");

            IWebElement state = sso.driver.FindElement(By.Id("id_state"));
            SelectElement stateselection = new SelectElement(state);
            stateselection.SelectByText("Florida");

            sso.driver.FindElement(By.Id("postcode")).SendKeys("23412");
            sso.driver.FindElement(By.Id("phone_mobile")).SendKeys("0123456789");
            sso.driver.FindElement(By.Id("alias")).SendKeys(" Home Address");            
        }


        public void CreateAccount()
        {
            sso.driver.FindElement(By.Id("submitAccount")).Click();
        }

        public bool IsAccountCreated()
        {
            var homeIcon = sso.driver.FindElement(homeIcon_logo).Displayed;
            return homeIcon;
//this is test branch
        }

    }
}

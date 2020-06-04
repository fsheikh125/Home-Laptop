using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    public class MyAccountPage
    {
      
        By MyAccount_txt = By.XPath("//h1[text()='My account']");
        
        ShareStateObjects sso;

        public MyAccountPage(ShareStateObjects _sso)
        {
            this.sso = _sso;

        }

        public bool IsMyAccountHeaderDisplayed()
        {
            return sso.driver.FindElement(MyAccount_txt).Displayed;
        }

    }
}

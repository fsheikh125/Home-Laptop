using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    class CommonPage
    {


        ShareStateObjects sso;

        public CommonPage(ShareStateObjects _sso)
        {
            this.sso = _sso;

        }
        public void NavigateTo(string url)
        {
            sso.driver.Navigate().GoToUrl(url);
        }
    }
}

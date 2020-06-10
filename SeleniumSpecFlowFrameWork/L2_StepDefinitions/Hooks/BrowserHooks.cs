using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions.Hooks
{
    [Binding]
    public class BrowserHooks
    {       
        ShareStateObjects sso;

        public BrowserHooks (ShareStateObjects _sso)
        {
            this.sso = _sso;
        }

        
        [BeforeScenario]
        public void SetUp ()
        {
           new DriverManager().SetUpDriver(new ChromeConfig());
            sso.driver = new ChromeDriver();
            //sso.driver.Url = x;
            sso.driver.Url = DataHooks.EnvData["baseurl"];
            int timespan = Int32.Parse(DataHooks.EnvData["default_timeout"]);
            sso.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timespan);
            sso.driver.Manage().Window.Maximize();
        }

       /* [AfterScenario]
        public void TearDown()
        {
            sso.driver.Quit();
        }*/
    }
}

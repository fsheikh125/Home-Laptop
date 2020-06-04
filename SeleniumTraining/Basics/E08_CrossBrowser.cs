using Microsoft.Edge.SeleniumTools;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.Basics
{
    class E08_CrossBrowser
    {
        [Test]
        public void CrossBrowserDemo()
        {

            

            IWebDriver driver;

            //driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            // driver = new InternetExplorerDriver();
            // driver = new EdgeDriver(); // legacy

            //https://developer.microsoft.com/en-us/microsoft-edge/tools/webdriver/ for edge
            //https://docs.microsoft.com/en-us/microsoft-edge/webdriver-chromium // new edge chromium
            // Make sure you download the chromium msedgedriver.exe from the above link for new chromium edge
            // for legacy follow the cmd prompt instruction to enble legacy webdriver as mentioned in above link.

            var options = new Microsoft.Edge.SeleniumTools.EdgeOptions();
            options.UseChromium = true;
            options.BinaryLocation = @"C:\Program Files (x86)\Microsoft\Edge Beta\Application\msedge.exe";


            driver = new Microsoft.Edge.SeleniumTools.EdgeDriver(options);




            driver.Url = "https://abrakh.com/";
            driver.Manage().Window.Maximize();
            Console.WriteLine(driver.Title);

        }

        }
}

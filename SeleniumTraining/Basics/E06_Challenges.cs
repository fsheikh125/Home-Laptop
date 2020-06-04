using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SeleniumTraining.Basics
{
    class E06_Challenges
    {

        [Test]
        public void FileUpload()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/upload";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("file-upload")).SendKeys("C:/Pros/a.txt");
            //driver.FindElement(By.Id("file-upload")).SendKeys("C:/Pros/b64.txt");
            driver.FindElement(By.Id("file-submit")).Click();

        }

        //FileDownload as assignment

            [Test]
        public void JSExecutor ()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://abrakh.com/";
            driver.Manage().Window.Maximize();
          // 1 way
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            js.ExecuteScript("window.scrollBy(0, 1000)");
            //driver.FindElement(By.XPath("//body")).SendKeys(Keys.PageDown);
            var header = driver.FindElement(By.XPath("//h1"));
            js.ExecuteScript("arguments[0].setAttribute('style', 'background: yellow; border: 3px solid red;');", header);
            // 2 way
            driver.ExecuteJavaScript("window.scrollBy(0, 1000)");

        }

        [Test]
        public void ScreenshotDemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://abrakh.com/";
            driver.Manage().Window.Maximize();
            var ts = currentDateTime();
            driver.TakeScreenshot().SaveAsFile("C:/Pros/asad/ss_"+ts+".png");
            var sshotElement = ((ITakesScreenshot)driver.FindElement(By.Id("guacBg14859"))).GetScreenshot();
            string ss = sshotElement.AsBase64EncodedString;
            File.WriteAllText(@"C:/Pros/asad/b64.txt", ss);
            
           


        }

        public  string currentDateTime()
        {
            
            return DateTime.Now.ToString("ddMMyyyy_HHmmss");
     
        }

        [Test]
        public void BasicAuth ()
        {
            IWebDriver driver = new ChromeDriver();
            //username:password@
            driver.Url = "https://admin:admin@the-internet.herokuapp.com/basic_auth";
             
        
        }

    }
}

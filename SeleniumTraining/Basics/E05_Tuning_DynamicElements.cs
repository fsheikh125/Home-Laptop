using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTraining.Basics
{
    class E05_Tuning_DynamicElements
    {
        [Test]
        public void DynamicElement1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/dynamic_loading/2";
            driver.Manage().Window.Maximize();
            // 2. Implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(90);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(20);

            driver.FindElement(By.XPath("//button")).Click();
           // Thread.Sleep(7000); // 1. hard wait  
            bool isHelloWorldDisplayed = driver.FindElement(By.Id("finish")).Displayed;
            Assert.IsTrue(isHelloWorldDisplayed);
           // Assert.IsTrue(driver.FindElement(By.Id("finish")).Displayed);

        }

        [Test]
        public void DynamicElement2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/dynamic_loading/1";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.FindElement(By.XPath("//button")).Click();
            //3. Explicit Wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            // wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h4[text()='Hello World!']")));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("loading")));
            

            bool isHelloWorldDisplayed = driver.FindElement(By.Id("finish")).Displayed;
            Assert.IsTrue(isHelloWorldDisplayed);

        }

        [Test]
        public void ifPopupisDisplayed()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.virginmedia.com/";
            driver.Manage().Window.Maximize();
            int DefaultTimeOut = 20;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(DefaultTimeOut);

            Thread.Sleep(7000); // to replicate the scenario of popu up box not present manually. just accept the link manually
            // This is for fine tuning set for lower value.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            if (driver.FindElements(By.PartialLinkText("Accept and")).Count !=0)
            {
                driver.FindElement(By.PartialLinkText("Accept and")).Click();
                
            }
            // reset it back to the defalut time out
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(DefaultTimeOut);
            Console.WriteLine("next line of code...");
        }


        }
}

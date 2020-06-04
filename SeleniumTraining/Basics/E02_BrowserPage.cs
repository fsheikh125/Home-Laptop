using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.Basics
{
    class E02_BrowserPage
    {
        [Test]
        public void PageDemo()
        {
            IWebDriver driver;
            
            driver= new ChromeDriver();
            driver.Url = "http://newtours.demoaut.com/";
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            By cruise = By.LinkText("Cruises");
            IWebElement linkCruises = driver.FindElement(cruise);
            linkCruises.Click();
 
            driver.FindElement(By.PartialLinkText("Hom")).Click();

            driver.FindElement(By.Name("userName")).SendKeys("mercury");
            driver.FindElement(By.Name("password")).SendKeys("mercury");
            driver.FindElement(By.XPath("//input[@name='login']")).Click();

            //Do some excercises on find element using other strategies.
            // Find the Check/radio box is selected or not
            // Find the Mecury Logo is displayed or not
            //Print value of href attribute for Contact Link
           
             Console.WriteLine(driver.FindElement(By.XPath("//input[@value='oneway']")).Selected);
            Assert.IsFalse(driver.FindElement(By.XPath("//input[@value='oneway']")).Selected);

            var airlineCombo = driver.FindElement(By.Name("airline"));
            SelectElement airlineElement = new SelectElement(airlineCombo);
            // airlineElement.SelectByIndex(2);
            airlineElement.SelectByText("Unified Airlines");
        
        }

        [Test]
        public void FindAllLinks()
        {

           IWebDriver driver = new ChromeDriver();
            driver.Url = "http://newtours.demoaut.com/";
           // ReadOnlyCollection<IWebElement> allLinks = driver.FindElements(By.XPath("//a"));
            var allLinks = driver.FindElements(By.XPath("//a"));
            var aa = allLinks.ToList<IWebElement>();
            Console.WriteLine(allLinks.Count);

           
            foreach (var item in allLinks)
            {
                Console.WriteLine(item.Text);
                Console.WriteLine(item.GetAttribute("outerHTML"));
            }

        }

    }
}

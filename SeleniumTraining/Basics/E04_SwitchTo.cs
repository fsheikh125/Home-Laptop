using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.Basics
{
    class E04_SwitchTo
    {
        [Test]
        public void SwitchFrame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.selenium.dev/selenium/docs/api/java/";
            driver.Manage().Window.Maximize();
            // Console.WriteLine(driver.PageSource); 
            driver.SwitchTo().Frame("classFrame");
            driver.FindElement(By.LinkText("TREE")).Click();

        }

        [Test]
        public void SwitchAlterts()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/javascript_alerts";
            driver.Manage().Window.Maximize();
           
            // 1st button
            driver.FindElement(By.XPath("//button[contains(text(), 'Click for JS Alert')]")).Click();
            Console.WriteLine(driver.SwitchTo().Alert().Text);
            driver.SwitchTo().Alert().Accept();

            //3rd button
            driver.FindElement(By.XPath("//button[text()='Click for JS Prompt']")).Click();
            driver.SwitchTo().Alert().SendKeys("myemail@gmail.com");
            driver.SwitchTo().Alert().Dismiss();
             // Grab the tile of alert and print if you can. HW 
             

             }

        [Test]
        public void SwitchWindows()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/windows";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Click Here")).Click();
           var windowhandles = driver.WindowHandles.ToList<string>();
            Console.WriteLine(windowhandles.ElementAt(1) );
            string newWindow = windowhandles.ElementAt(1);
            driver.SwitchTo().Window(newWindow);
            driver.Url = "https://www.bbc.com/";
            driver.Close();
            

            //going back to the original window
            driver.SwitchTo().Window(windowhandles.ElementAt(0));
            driver.Url = "https://www.google.com/";




        }


        }
    }

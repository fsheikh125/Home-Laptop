using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace SeleniumTraining.Basics
{
    class E01_BrowserWindow
    {
        [Test]
        public void WindowDemo()
        {
            IWebDriver driver= new ChromeDriver();

            driver.Url = "https://abrakh.com/";
            
            driver.Manage().Window.Maximize();
            
            
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();
            Console.WriteLine(driver.CurrentWindowHandle);
            //Console.WriteLine(driver.PageSource);
            //Write this PAge source string to File
            Size s = new Size(500, 300);
            driver.Manage().Window.Size = s;
            //Extra Mile - Resize the window from 800 width to 200 width reducing 1 pixel at a time. use for loop
            Console.WriteLine(driver.Title);
            string tt = driver.Title;
            Assert.AreEqual("Google", tt);

          

            driver.Quit();


        }

    }
}

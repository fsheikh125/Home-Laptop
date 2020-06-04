using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.Basics
{
    class E03_Actions
    {
        [Test]
        public void Hovering()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://automationpractice.com";
            driver.Manage().Window.Maximize();
            IWebElement dressLink = driver.FindElement(By.LinkText("DRESSES"));
            
            Actions actions = new Actions(driver);
            actions.MoveToElement(dressLink).Click().Build().Perform();

        }

        [Test]
        public void DoubleClick()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://automationpractice.com";
            driver.Manage().Window.Maximize();
            IWebElement phoneNumber = driver.FindElement(By.XPath("//strong[text()='0123-456-789']"));

            Actions actions = new Actions(driver);
            actions.MoveToElement(phoneNumber).DoubleClick().Build().Perform();
            
            Console.WriteLine(phoneNumber.Text);

            actions.MoveToElement(phoneNumber).ContextClick().Build().Perform();
        }

        [Test]
        public void KeyBoardActions()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://automationpractice.com";
            driver.Manage().Window.Maximize();

            var searchBox = driver.FindElement(By.Id("search_query_top"));
            Actions actions = new Actions(driver);

            actions.MoveToElement(searchBox).Click().KeyDown(Keys.Shift)
                .SendKeys("a").KeyUp(Keys.Shift).SendKeys("bdul").SendKeys(Keys.Enter).Build().Perform();

        }

        [Test]
        public void MouseDragAndDrop()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://jqueryui.com/droppable/";
            driver.Manage().Window.Maximize();
            // var frame1 = driver.FindElement(By.ClassName("demo-frame"));
            //driver.SwitchTo().Frame(frame1);
            driver.SwitchTo().Frame(0);

            var draggable = driver.FindElement(By.Id("draggable"));
            var droppable = driver.FindElement(By.Id("droppable"));

           
            Actions actions = new Actions(driver);
            actions.DragAndDrop(draggable, droppable).Build().Perform();

        }

    }
}

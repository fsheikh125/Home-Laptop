using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.Basics
{
    class E07_DynamicTables
    {
        IWebDriver driver = new ChromeDriver();
        [Test]
        public void TableDemo()
        {
            //driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/tables";
            driver.Manage().Window.Maximize();

            int rowIndex = GetRowIndex("Conway");
            Console.WriteLine(rowIndex);

            // int columnIndex = GetColumnIndex("WebSite"); // This is assignment.

            int columnIndex = 2;
            var value = driver.FindElement(By.XPath("//table[@id='table1']/tbody/tr[" + rowIndex + "]/td[" + columnIndex + "]")).Text;

            Console.WriteLine(value);


        }


       

        public int GetRowIndex (string name)
        {
            var noOfRows = driver.FindElements(By.XPath("//table[@id='table1']/tbody/tr")).Count;
            for (int i = 1; i <= noOfRows; i++)
            {
                var rowname = driver.FindElement(By.XPath("//table[@id='table1']/tbody/tr[" + i + "]/td[1]")).Text;
                if (rowname == name)
                {
                    return i;
                }

            }

            return 0;

        }
    }
}

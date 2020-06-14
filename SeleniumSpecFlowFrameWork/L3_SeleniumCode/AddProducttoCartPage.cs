using MongoDB.Driver.Core.Operations;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumSpecFlowFrameWork.Global;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    class AddProducttoCartPage
    {
        ShareStateObjects sso;
        IWebDriver driver;
        public AddProducttoCartPage(ShareStateObjects _sso)
        {
            sso = _sso;
            driver = sso.driver;
        }

        public void SelectDress(string p0)
        {
            //var dressCount = sso.driver.FindElements(By.XPath("//ul[@id='homefeatured']//a[@class='product-name']")).Count;

            //for (int i = 1; i <= dressCount; i++)
            //{
            //    string dressName = sso.driver.FindElement(By.XPath("(//ul[@id='homefeatured']/li)[" + i + "]//div[@class='right-block']//a[@class='product-name']")).Text;
            //    string name = dressName.Trim();

            //    if (name == p0)
            //    {
            //        sso.driver.FindElement(By.XPath("(//ul[@id='homefeatured']/li)[" + i + "]//div[@class='right-block']//a[@class='product-name']")).Click();
            //        sso.driver.FindElement(By.XPath("")).Click();


            //    }

            //}
            Actions actions = new Actions(driver);

            var itemlink = driver.FindElement(By.XPath("(//a[@class='product-name' and @title='" + p0 + "'])[1]"));
            actions.MoveToElement(itemlink).Build().Perform();

            driver.FindElement(By.XPath("(//a[@class='product-name' and @title='" + p0 + "'])[1]/../..//span[text()='Add to cart']")).Click();
                
        }
    }
}
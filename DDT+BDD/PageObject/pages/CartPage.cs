using OpenQA.Selenium;
using System;

namespace DDT_BDD.PageObject.pages
{
    public class CartPage:BasePage
    {
        public CartPage(IWebDriver driver):base(driver) { }

        private readonly By totalSum = By.XPath("//div[@class='cart-receipt__sum-price']//span[not(@class)]");

        public double GetTotalSumFromPage()
        {
            WaitUntilElementExists(totalSum);
            string sum = driver.FindElement(totalSum).Text;
            return Convert.ToDouble(sum);
        }
    }
}

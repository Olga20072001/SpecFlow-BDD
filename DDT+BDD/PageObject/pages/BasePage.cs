using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace DDT_BDD.PageObject.pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        protected WebDriverWait wait;
        protected readonly long timeToWait = 30;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;            
        }

        public void EnsureRozetkaIsOpen(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void WaitUntilElementExists(By element)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait)).Until(ExpectedConditions.ElementExists(element));
        }

    }

}

using BoDi;
using DDT_BDD.Drivers;
using DDT_BDD.PageObject.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace DDT_BDD.Steps
{
    [Binding]
    class RozetkaStepsDefinitions
    {
        private readonly BasePage _basePage;
        private readonly HomePage _homePage;
        private readonly SearchResultPage _searchResultPage;
        private readonly ProductPage _productPage;
        private readonly CartPage _cartPage;

        public RozetkaStepsDefinitions(BrowserDriver browserDriver)
        {
            _basePage = new BasePage(browserDriver.Current);
            _homePage = new HomePage(browserDriver.Current);
            _searchResultPage = new SearchResultPage(browserDriver.Current);
            _productPage = new ProductPage(browserDriver.Current);
            _cartPage = new CartPage(browserDriver.Current);
        }

        [Given(@"User opens (.*) page")]
        public void GivenUserOpensPage(string url)
        {
            _basePage.EnsureRozetkaIsOpen(url);
        }

        [When(@"User makes search by keyword (.*)")]
        public void WhenUserMakesSearchByKeyword(string searchProduct)
        {
            _homePage.SearchByKeyword(searchProduct);
        }

        [When(@"User choose the (.*) brand")]
        public void WhenUserChooseTheBrand(string brand)
        {
            _searchResultPage.SearchBrandName(brand);
        }

        [When(@"User sorts products by (.*)")]
        public void WhenUserSortsProductsBy(string sortedValue)
        {
            _searchResultPage.OrderBy(sortedValue);
        }

        [When(@"User clicks on the first product")]
        public void WhenUserClicksOnTheFirstProduct()
        {
            _searchResultPage.getItemByIndex(0);
        }

        [When(@"User clicks Add to cart button")]
        public void WhenUserClicksAddToCartButton()
        {
            _productPage.ClickBuyButton();
        }
        [When(@"User clicks Cart button")]
        public void WhenUserClicksCartButton()
        {
            _productPage.ClickCartButton();
        }
        [Then(@"User checks the sum in the cart more than (.*)")]
        public void ThenUserChecksTheSumInTheCart(string price)
        {
            Assert.Greater(_cartPage.GetTotalSumFromPage(), Convert.ToDouble(price));
        }


    }
}

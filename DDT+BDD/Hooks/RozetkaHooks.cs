using DDT_BDD.Drivers;
using DDT_BDD.PageObject.pages;
using TechTalk.SpecFlow;

namespace DDT_BDD.Hooks
{
    [Binding]
    class RozetkaHooks
    {
        [BeforeScenario]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var homePage = new HomePage(browserDriver.Current);
            var searchResultPage = new SearchResultPage(browserDriver.Current);
            var productPage = new ProductPage(browserDriver.Current);
            var cartPage = new CartPage(browserDriver.Current);
        }

    }
}

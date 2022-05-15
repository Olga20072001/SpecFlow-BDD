using BoDi;
using DDT_BDD.Drivers;
using TechTalk.SpecFlow;

namespace DDT_BDD.Hooks
{
    [Binding]
    class ShareBrowserHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun(ObjectContainer testThreadContainer)
        {
            testThreadContainer.BaseContainer.Resolve<BrowserDriver>();
        }
    }
}

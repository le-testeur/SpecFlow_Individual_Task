using BoDi;
using OpenQA.Selenium.Chrome;
using SpecFlow_Individual_Task.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlow_Individual_Task.Hooks
{
    [Binding]
    public sealed class BaseHooks : DriverSupport
    {
        IObjectContainer container;
        public BaseHooks(IObjectContainer _container)
        {
            container = _container;
        }

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized", "--incognito");
            options.AddArgument("--disable-popup-blocking");
            options.AddExcludedArgument("enable-automation");
            driver = new ChromeDriver(options);
            container.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
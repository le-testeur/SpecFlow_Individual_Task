using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecFlow_Individual_Task.CustomExtensions
{
    public static class MyExtensions
    {
        public static string AddRandomExtension(string text1, string text2) =>
            text1 + new Random().Next(1, 999) + text2;

        public static void SelectByText(IWebElement element, string text)
        {
            SelectElement selectelement = new SelectElement(element);
            selectelement.SelectByText(text);
        }

        public static IJavaScriptExecutor scrollToAndClickElement(this IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView()", element);
            js.ExecuteScript("arguments[0].click()", element);
            return js;
        }
    }

    public static class CustExtensions
    { 
        public static void WaitMethod(this IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}


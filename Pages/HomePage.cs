using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using OpenQA.Selenium;
using SpecFlow_Individual_Task.CustomExtensions;
using SpecFlow_Individual_Task.Drivers;
using SpecFlow_Individual_Task.Utility;

namespace SpecFlow_Individual_Task.Pages
{
    public class HomePage : DriverSupport
    {
        JsonClass jClass;
        public HomePage(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            jClass = container.Resolve<JsonClass>();
        }

        IWebElement ValidateSite => driver.FindElement(By.XPath("(//div[@class='col-sm-4'])[2]"));
        IWebElement signUpLink => driver.FindElement(By.LinkText("Signup / Login"));
        IWebElement signedIn => driver.FindElement(By.TagName("<b>"));
        //IWebElement deleteButton => driver.FindElement(By.LinkText("Delete Account"));
        IWebElement validateHomePage => driver.FindElement(By.CssSelector("div[class='logo pull-left']"));
        public void NavigateToSite() => 
            driver.Navigate().GoToUrl(jClass.ReadJsonData("Environ:AE_Url"));

        public bool isSiteValid() => ValidateSite.Displayed;

        public void ClickLinkText() => signUpLink.Click();

        public bool ValidateUsername() => ValidateSite.Displayed;   
        
        //public void ClickDeleteButton() => deleteButton.Click();

        public void WaitForReturnToHomepage() =>
        driver.WaitMethod(By.CssSelector("div[class='logo pull-left']"));
        public bool ReturnToHomePage() => validateHomePage.Displayed;
    }
}

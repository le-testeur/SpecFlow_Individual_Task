using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using OpenQA.Selenium;
using SpecFlow_Individual_Task.CustomExtensions;
using SpecFlow_Individual_Task.Drivers;

namespace SpecFlow_Individual_Task.Pages
{
    public class AccountCreatedPage : DriverSupport
    {
        public AccountCreatedPage(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
        }

        IWebElement acctCreatedMsg => driver.FindElement(By.XPath("//h2[@data-qa='account-created']//b"));
        IWebElement signUpLink => driver.FindElement(By.LinkText("Signup / Login"));

        public void WaitForSuccessMsg() => driver.WaitMethod(By.XPath("//h2[@data-qa='account-created']//b"));
        
        public bool SuccessMsg() => acctCreatedMsg.Displayed;

        public void ClickLinkText() => signUpLink.Click();
    }
}

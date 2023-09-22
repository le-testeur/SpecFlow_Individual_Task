using System;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlow_Individual_Task.Drivers;
using SpecFlow_Individual_Task.Pages;
using TechTalk.SpecFlow;

namespace SpecFlow_Individual_Task.StepDefinitions
{
    [Binding]
    public class AccountCreatedPageStepDefinitions : DriverSupport
    {
        AccountCreatedPage acctCreatedPage;
        public AccountCreatedPageStepDefinitions(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            acctCreatedPage = container.Resolve<AccountCreatedPage>();
        }

        [Then(@"I will arrive on the account confirmation screen")]
        public void ThenIWillArriveOnTheAccountConfirmationScreen()
        {
            acctCreatedPage.WaitForSuccessMsg();
            var isSuccessMsgDisplayed = acctCreatedPage.SuccessMsg();
            Assert.True(isSuccessMsgDisplayed);
        }

        [When(@"I click on the signup / Login link")]
        public void WhenIClickOnTheSignupLoginLink()
        {
            acctCreatedPage.ClickLinkText();
        }
    }
}

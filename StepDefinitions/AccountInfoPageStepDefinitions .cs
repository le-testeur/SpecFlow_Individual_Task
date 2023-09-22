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
    public class AccountInfoPageStepDefinitions : DriverSupport
    {
        AccountInfoPage acctPage;
        public AccountInfoPageStepDefinitions(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();  
            acctPage = container.Resolve<AccountInfoPage>();
        }
        [Then(@"I will arrive on the Account information page")]
        public void ThenIWillArriveOnTheAccountInformationPage()
        {
            var validateAccountInfoPage = acctPage.AccountInfoPageIsDisplayed();
            Assert.True(validateAccountInfoPage);
        }

        [When(@"I enter the following data")]
        public void WhenIEnterTheFollowingData()
        {
            acctPage.ClickTitle();
            acctPage.EnterAllData();
        }

        [When(@"Click the create account button")]
        public void WhenClickTheCreateAccountButton()
        {
            acctPage.ClickCreateButton();
        }
    }
}

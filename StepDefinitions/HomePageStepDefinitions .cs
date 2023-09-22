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
    public class HomePagePageStepDefinitions : DriverSupport
    {
        HomePage hpage;
        public HomePagePageStepDefinitions(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            hpage = container.Resolve<HomePage>();  
        }
        [Given(@"I navigate to the Automation Exercise site")]
        public void GivenINavigateToTheAutomationExerciseSite()
        {
            hpage.NavigateToSite();
        }

        [Then(@"I will arrive on the Automation Exercise home page")]
        public void ThenIWillArriveOnTheAutomationExerciseHomePage()
        {
            hpage.isSiteValid();
            var validateOnSite = hpage.isSiteValid();
            Assert.True(validateOnSite);
        }

        [When(@"I click on the sign up/ Login link")]
        public void WhenIClickOnTheSignUpLoginLink()
        {
            hpage.ClickLinkText();
        }

        [Then(@"I will be logged in as my username in the homePage")]
        public void ThenIWillBeLoggedInAsMyUsernameInTheHomePage()
        {
            hpage.ValidateUsername();
            var isUserNameDisplayed = hpage.ValidateUsername();
            Assert.True(isUserNameDisplayed);   
        }

        //[When(@"I click the Delete Account button")]
        //public void WhenIClickTheDeleteAccountButton()
        //{
        //    hpage.ClickDeleteButton();
        //}

        [Then(@"I will return to the Home Page")]
        public void ThenIWillReturnToTheHomePage()
        {
            hpage.WaitForReturnToHomepage();
            hpage.ReturnToHomePage();
        }
    }
}

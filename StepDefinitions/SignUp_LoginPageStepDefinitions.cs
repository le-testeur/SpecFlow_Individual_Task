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
    public class SignUp_LoginPageStepDefinitions : DriverSupport
    {
        SignUp_LoginPage sLpage;
        public SignUp_LoginPageStepDefinitions(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            sLpage = container.Resolve<SignUp_LoginPage>();
        }
        [Then(@"I will arrive on the signup/login in page")]
        public void ThenIWillArriveOnTheSignupLoginInPage()
        {
            sLpage.isSignupFormDisplayed();
            var validatePage = sLpage.isSignupFormDisplayed();
            Assert.True(validatePage);
        }

        [When(@"I enter my name and email address")]
        public void WhenIEnterMyNameAndEmailAddress()
        {
            sLpage.EnterSignUpData();
        }

        [When(@"I click on the signup button")]
        public void WhenIClickOnTheSignupButton()
        {
            sLpage.ClickSignUpButton();
        }
    }
}

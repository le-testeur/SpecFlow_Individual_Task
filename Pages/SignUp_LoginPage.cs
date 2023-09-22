using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BoDi;
using OpenQA.Selenium;
using SpecFlow_Individual_Task.CustomExtensions;
using SpecFlow_Individual_Task.Drivers;
using SpecFlow_Individual_Task.Utility;

namespace SpecFlow_Individual_Task.Pages
{
    public class SignUp_LoginPage : DriverSupport
    {
        JsonClass jClass;
        public SignUp_LoginPage(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            jClass = container.Resolve<JsonClass>();
        }

        IWebElement signupForm => driver.FindElement(By.CssSelector("div[class='signup-form']"));
        IWebElement enterSignUpName => driver.FindElement(By.CssSelector("input[name='name']"));
        IWebElement enterSignUpEmail => driver.FindElement(By.XPath("(//input[@name='email'])[2]"));
        IWebElement signUpButton => driver.FindElement(By.XPath("(//button[@type='submit'])[2]"));


        public bool isSignupFormDisplayed() => signupForm.Displayed;

        public void EnterSignUpData()
        {
            enterSignUpName.SendKeys(jClass.ReadJsonData("NewUser_SignUp:Name"));
            enterSignUpEmail.SendKeys(MyExtensions.AddRandomExtension(jClass.ReadJsonData("NewUser_SignUp:Email1"),
            jClass.ReadJsonData("NewUser_SignUp:Email2")));
        }

        public void ClickSignUpButton() => signUpButton.Click();
    }
}

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
    public class AccountInfoPage : DriverSupport
    {
        JsonClass jClass;
        public AccountInfoPage(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            jClass = container.Resolve<JsonClass>();    
        }
        IWebElement accountInfoForm => driver.FindElement(By.XPath("//div[contains(@class, 'login-form')]"));
        private IWebElement Mr => driver.FindElement(By.Id("id_gender1"));
        private IWebElement Password => driver.FindElement(By.CssSelector("#password"));
        private IWebElement Days => driver.FindElement(By.Id("days"));
        private IWebElement Months => driver.FindElement(By.CssSelector("#months"));
        private IWebElement Year => driver.FindElement(By.CssSelector("#years"));
        private IWebElement FirstName => driver.FindElement(By.XPath("//input[@id='first_name']"));
        private IWebElement LastName => driver.FindElement(By.XPath("//input[@id='last_name']"));
        IWebElement Company => driver.FindElement(By.CssSelector("#company"));
        IWebElement Address1 => driver.FindElement(By.CssSelector("#address1"));
        private IWebElement Address2 => driver.FindElement(By.CssSelector("#address2"));
        private IWebElement Country => driver.FindElement(By.Id("country"));
        private IWebElement State => driver.FindElement(By.CssSelector("#state"));
        private IWebElement City => driver.FindElement(By.XPath("//input[@id='city']"));
        private IWebElement ZipCode => driver.FindElement(By.XPath("//input[@id='zipcode']"));
        private IWebElement Mobile => driver.FindElement(By.XPath("//input[@id='mobile_number']"));
        private IWebElement CreateAccount => driver.FindElement(By.XPath("(//button[@type='submit'])[1]"));

        public bool AccountInfoPageIsDisplayed() => accountInfoForm.Displayed;
        public void ClickTitle() => Mr.Click(); 
        public void EnterAllData()
        {
            Password.SendKeys(jClass.ReadJsonData("Account_Info:Password"));
            Days.SendKeys(jClass.ReadJsonData("Account_Info:Day"));
            Months.SendKeys(jClass.ReadJsonData("Account_Info:Month"));
            Year.SendKeys(jClass.ReadJsonData("Account_Info:Year"));
            FirstName.SendKeys(jClass.ReadJsonData("Account_Info:First name"));
            LastName.SendKeys(jClass.ReadJsonData("Account_Info:Last name"));
            Company.SendKeys(jClass.ReadJsonData("Account_Info:Company"));
            Address1.SendKeys(jClass.ReadJsonData("Account_Info:Address1"));
            Address2.SendKeys(jClass.ReadJsonData("Account_Info:Address2"));
            Country.SendKeys(jClass.ReadJsonData("Account_Info:Country"));
            State.SendKeys(jClass.ReadJsonData("Account_Info:State"));
            City.SendKeys(jClass.ReadJsonData("Account_Info:City"));
            ZipCode.SendKeys(jClass.ReadJsonData("Account_Info:Zipcode"));
            Mobile.SendKeys(jClass.ReadJsonData("Account_Info:Mobile number"));
        }
        public void ClickCreateButton()
        {
            CreateAccount.scrollToAndClickElement(driver);
        } 
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowNetCoreDemo.Pages
{
   public class LogInPage
    {

        public IWebDriver WebDriver { get; }

        public LogInPage(IWebDriver webDriver)
        {

            WebDriver = webDriver;
        }

        //UI Elements
        public IWebElement lnkLogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement txtUserName => WebDriver.FindElement(By.Name("UserName"));
        public IWebElement txtPassword => WebDriver.FindElement(By.Id("Password"));
        public IWebElement btnLogin => WebDriver.FindElement(By.XPath("//input[@value='Log in']"));
        public IWebElement lnkEmployeeDetails => WebDriver.FindElement(By.XPath("//a[normalize-space()='Employee List']"));

        //Method for executing steps

        public void ClickLogin() => lnkLogin.Click();

        public void Login(string userName, string passWord)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(passWord);

        }

        public void ClickLoginButton() => btnLogin.Submit();

        public bool IsEmployeeDetailsExist() => lnkEmployeeDetails.Displayed;


    }
}

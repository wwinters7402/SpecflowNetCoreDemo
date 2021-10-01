using SpecflowNetCoreDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace SpecflowNetCoreDemo.Steps
{
    [Binding]
    public sealed class LogInSteps
    {

        //Anti Context Injection code - 100% wrong

        //Step Definitions

        LogInPage loginPage = null;


        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {

          
           

            IWebDriver webDriver = new ChromeDriver();
            
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            webDriver.Manage().Window.Maximize();
            loginPage = new LogInPage(webDriver);
        }

        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            loginPage.ClickLogin();
        }



        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance(); 
            loginPage.Login((string)data.UserName, (string)data.Password);
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            Assert.That(loginPage.IsEmployeeDetailsExist(), Is.True);
        }

        [Given(@"I click the log off button")]
        public void GivenIClickTheLogOffButton()
        {
            loginPage.ClickLogOff();
        }

    }
}

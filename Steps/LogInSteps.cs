using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowNetCoreDemo.Steps
{
    [Binding]
    public sealed class LogInSteps
    {
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            ScenarioContext.Current.Pending();
        }

    }
}

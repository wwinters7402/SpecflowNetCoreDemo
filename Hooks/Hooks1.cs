using AventStack.ExtentReports.Reporter;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

namespace SpecflowNetCoreDemo.Hooks
{
    [Binding]
    public sealed class GeneralHook
    {
        private static ScenarioContext _scenarioContext;
        private static FeatureContext _featureContext;
        private static ExtentReports _extentReports;
        private static ExtentHtmlReporter _extentHtmlReporter;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _extentHtmlReporter = new ExtentHtmlReporter(@"D:\Specflow\HTMLReports");
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extentHtmlReporter);

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            if (null != featureContext)
            {
                _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title, featureContext.FeatureInfo.Description);

            }
        }
        [BeforeScenario]

        public static void BeforeScenarioStart(ScenarioContext scenarioContext)
        {
            if (null != scenarioContext)
            {

                _scenarioContext = scenarioContext;
                _scenario =_feature.CreateNode<Scenario>
                    (scenarioContext.ScenarioInfo.Title, scenarioContext.ScenarioInfo.Description);

            }

        }

        [AfterStep]
        public void AfterEachStep()
        {

            //logic -> Given,when or then
            // add the node

            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;

            //switch case

            switch (scenarioBlock)
            {


                case ScenarioBlock.Given:
                    _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                    break;

                case ScenarioBlock.When:
                    _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                    break;

                case ScenarioBlock.Then:
                    _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                    break;

                default:
                    _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);

                    break;
            }
        }

            [AfterTestRun]
            public static void AfterTestRun()
            {
            _extentReports.Flush();
                
            }



        }

    }


    
    


        
     
    


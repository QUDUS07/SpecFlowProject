using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public  class YoutubeSearchFeatureStepDefinitions
    {
        public IWebDriver driver;



        [Given(@"I open my web broswer")]
        public void GivenIOpenMyWebBroswer()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"I Navigate to Website")]
        public void WhenINavigateToWebsite()
        {
            driver.Url = "https://www.youtube.com/";
               Thread.Sleep(5000);
        }

        [Then(@"Search for Tester Talk")]
        public void ThenSearchForTesterTalk()
        {
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys("Tester Talk");
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);


            driver.Quit();
        }


        
      



    }

}

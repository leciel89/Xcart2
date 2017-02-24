using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace Xcart2
{
    [Binding]
    public class Login_FeatureSteps
    {
        public IWebDriver driver;
        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            driver = new FirefoxDriver();
            driver.Url = "http://192.168.1.6/";
            
        }
        [Given(@"Navigate to Manage Page")]
        public void GivenUserNavigateToLogInPage()
            {
            driver.FindElement(By.XPath(".//*[@id=bitnami-close-banner-button]")).Click();
            driver.Quit();
            
        }

        
        
      //  [When(@"I press add")]
      //  public void WhenIPressAdd()
       // {
        //    ScenarioContext.Current.Pending();
      //  }
        
      //  [Then(@"the result should be (.*) on the screen")]
       // public void ThenTheResultShouldBeOnTheScreen(int p0)
       // {
       //     ScenarioContext.Current.Pending();
       // }
    }
}

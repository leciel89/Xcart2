using System;
using System.Collections;
using System.Collections.ObjectModel;
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
        [Given(@"Navigate to Login Page")]
        public void GivenUserNavigateToLogInPage()
            {
                driver.FindElement(By.XPath("//div[@class='header_bar-sign_in']")).Click();
                                     
        }
         [When(@"User enter <email> and <pass>")]
        public void WhenUserEnterEmailAndPassword()
         {
             {
                 string foundpopup = string.Empty;
                 string Mainwindow = driver.CurrentWindowHandle;
                 ReadOnlyCollection<string> WindowHandles = driver.WindowHandles;
                                  
             foreach (string handle in WindowHandles)
             {                             
                 if (handle != Mainwindow)                       
                               
                 foundpopup = handle; break;  
                 }
              driver.SwitchTo().Window(foundpopup);  
              driver.FindElement(By.XPath("//input[@id='login-email']")).SendKeys("sao_choi_89@yahoo.com");
              driver.FindElement(By.XPath("//input[@id='login-password']")).SendKeys("honghanh");   
              driver.FindElement(By.ClassName("btn  regular-button  submit")).Click();
              driver.Close();
              driver.SwitchTo().Window(Mainwindow);     
                     }
                      }                   
          [Then(@"user can login successfully")]
        public void UserCanLoginSuccessfully()
        {
            true.Equals(driver.FindElement(By.XPath(".//*[@id='dropdown header_bar-my_account']/a")).Displayed);
        }
    
    }

}

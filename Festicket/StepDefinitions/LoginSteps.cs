using System;
using Festicket.PageObjects;
using Festicket.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Festicket.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage Login;

        public LoginSteps()
        {
            Login = new LoginPage();
        }

        [Given(@"I Navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("https://www.festicket.com/");
            Hooks.Driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(5000); 
        }
        
        [When(@"I Click on Login button")]
        public void WhenIClickOnLoginButton()
        {
            
            Login.Clicklogin();
            System.Threading.Thread.Sleep(3000);
        }
        
        [When(@"I enter Email address")]
        public void WhenIEnterEmailAddress()
        {
            Login.EnterEmailAddress("sumboodukoya@yahoo.com");
            System.Threading.Thread.Sleep(3000);
        }
        
        [When(@"I enter Password")]
        public void WhenIEnterPassword()
        {
            Login.EnterPassword("patient01");
            System.Threading.Thread.Sleep(3000);
        }
        
        [When(@"I click on Login")]
        public void WhenIClickOnLogin()
        {
            Login.ClickLogin();
            System.Threading.Thread.Sleep(3000);
        }
        
        
        [When(@"I click on User Image")]
        public void WhenIClickOnUserImage()
        {
            Login.ClickUserImage();
            System.Threading.Thread.Sleep(3000);
        }
        
        [When(@"I Click Logout")]
        public void WhenIClickLogout()
        {
            Login.ClickLogout();
            System.Threading.Thread.Sleep(3000);
        }
        
        [Then(@"I am Logout")]
        public void ThenIAmLogout()
        {
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(Login.OwnShareMessageIsDisplayed());
      
        }
    }
}

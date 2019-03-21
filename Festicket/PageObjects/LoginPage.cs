using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Festicket.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Festicket.PageObjects
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='root']/main/header/div[2]/nav/ul/div/button/span/span")]
        private IWebElement login { get; set; }

        public void Clicklogin()
        {
            login.Click();
        }

        [FindsBy(How = How.Id, Using = "emailInput")]
        private IWebElement EmailAddress { get; set; }

       public void EnterEmailAddress(string emailaddresstext)
        {
            EmailAddress.SendKeys(emailaddresstext);
        }
        [FindsBy(How = How.Id, Using = "passwordInput")]
        private IWebElement Password { get; set; }

        public void EnterPassword(string passwordtext)
        {
            Password.SendKeys(passwordtext);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='submitButton']/span")]
        private IWebElement  Login { get; set; }

        public void ClickLogin()
        {
            Login.Click();
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/header/div[2]/nav/ul/div/div/div[1]/span")]
        private IWebElement UserImage { get; set; }

        public void ClickUserImage()
        {
            UserImage.Click();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='root']/main/header/div[2]/nav/ul/div/div/div[2]/div[2]/a[4]")]
        private IWebElement Logout{ get; set; }

        public void ClickLogout()
        {
            Logout.Click();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='root']/main/div[1]/div/a")]
        private IWebElement OwnShareMessage { get; set; }

        public bool OwnShareMessageIsDisplayed()
        {
            return OwnShareMessage.Displayed;
        }













    }

}

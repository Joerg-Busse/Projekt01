using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ExtensionMethods
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObjects Login(string username, string password)
        {
            ////Username
            //txtUserName.SendKeys(username);
            ////Password
            //txtPassword.SendKeys(password);
            ////Buttonclick
            //btnLogin.Click(); //btnLogin.Submit();

            //Besser mit den extension methods
            ////Username
            //txtUserName.EnterText(username);
            ////Password
            //txtPassword.EnterText(password);
            ////Buttonclick
            //btnLogin.Clicks(); //btnLogin.Submit();

            return new EAPageObjects();
        }
    }
}

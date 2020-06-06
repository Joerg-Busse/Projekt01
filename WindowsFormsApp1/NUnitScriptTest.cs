using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using WindowsFormsApp1.ExtensionMethods;
using OpenQA.Selenium.Firefox;

namespace WindowsFormsApp1
{
    public class NUnitScriptTest
    {       

        [SetUp]
        public void Initialize()
        {
            //SetUp: The SetUp attribute is used to identify a method 
            //to be called immediately; each test runs.

            PropertiesCollection.driver = new FirefoxDriver();

            //open the browser              
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.google.de/");
            PropertiesCollection.driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Console.WriteLine("Start Chrome Browser");
        }

        [Test]
        public void ExecuteTest()
        {
            //Login to Application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObjects pageEA = pageLogin.Login("derusername", "daspasswort");
            pageEA.FillUserForm("triebwerk duisburg");

            
            //Page initialisieren und dessen reference aufrufen
            //EAPageObjects pageEA = new EAPageObjects();
            //pageEA.txtQ.SendKeys("triebwerk duisburg");
            //pageEA.btnBtnK.Click();


            //SeleniumSetMethods.EnterText("q", "triebwerk duisburg", PropertyType.Name);
            //Console.WriteLine("The value for q is : " + SeleniumGetMethods.GetText("q", PropertyType.Name));
            

            //SeleniumSetMethods.Click("btnK", PropertyType.Name); => wirft bei Firefox Browser fehler
            //IWebElement eleBtn = PropertiesCollection.driver.FindElement(By.Name("btnK"));
            //IJavaScriptExecutor js = (IJavaScriptExecutor)PropertiesCollection.driver;
            //js.ExecuteScript("arguments[0].click();", eleBtn);
            //Thread.Sleep(2000);
            

            //perform browser operations  
            //IWebElement ele = PropertiesCollection.driver.FindElement(By.Name("q"));
            //ele.SendKeys("triebwerk duisburg");
            //Thread.Sleep(2000);


            //IWebElement eleBtn = PropertiesCollection.driver.FindElement(By.Name("btnK"));
            //IJavaScriptExecutor js = (IJavaScriptExecutor)PropertiesCollection.driver;
            //js.ExecuteScript("arguments[0].click();", eleBtn);
            //Thread.Sleep(2000);
        }

        [TearDown]
        public void EndTest()
        {
            //TearDown: this attribute is used to identify a method 
            //that is to be called immediately after each test is executed. 
            //And this method is guaranteed to be called, even if an exception is thrown.

            //close the browser 
            PropertiesCollection.driver.Close();
        }
    }
}

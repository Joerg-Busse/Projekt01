using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace WindowsFormsApp1
{
    class NUnitScriptTest
    {
        IWebDriver driver = new FirefoxDriver();

        [SetUp]
        public void Initialize()
        {
            //SetUp: The SetUp attribute is used to identify a method 
            //to be called immediately; each test runs.

            //open the browser              
            driver.Navigate().GoToUrl("https://www.google.de/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Test]
        public void ExecuteTest()
        {
            //perform browser operations  
            IWebElement ele = driver.FindElement(By.Name("q"));
            ele.SendKeys("triebwerk duisburg");
            Thread.Sleep(2000);

            IWebElement eleBtn = driver.FindElement(By.Name("btnK"));

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", eleBtn);
            Thread.Sleep(2000);
        }

        [TearDown]
        public void EndTest()
        {
            //TearDown: this attribute is used to identify a method 
            //that is to be called immediately after each test is executed. 
            //And this method is guaranteed to be called, even if an exception is thrown.

            //close the browser 
            driver.Close();
        }
    }
}

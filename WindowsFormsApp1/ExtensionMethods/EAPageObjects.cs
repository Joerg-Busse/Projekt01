using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsFormsApp1.ExtensionMethods;

namespace WindowsFormsApp1
{
    class EAPageObjects
    {
        public EAPageObjects()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement txtQ { get; set; }

        //[FindsBy(How = How.Id, Using = "feldId")]
        //public IWebElement ddlFeldId { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement btnBtnK { get; set; }

        public void FillUserForm(string q)
        {
            txtQ.EnterText(q);
            //SeleniumSetMethods.EnterText(txtQ, q);
            //txtQ.SendKeys(q);
            //btnBtnK.Click(); //klappt beim firefox irgendwie nicht => 
            //SeleniumSetMethods.Click(btnBtnK); //klappt beim firefox irgendwie nicht =>
            //also =>
            IWebElement eleBtn = PropertiesCollection.driver.FindElement(By.Name("btnK"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)PropertiesCollection.driver;
            js.ExecuteScript("arguments[0].click();", eleBtn);
            Thread.Sleep(2000);
        }
    }
}

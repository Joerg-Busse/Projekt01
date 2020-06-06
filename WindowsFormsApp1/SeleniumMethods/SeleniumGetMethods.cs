using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.UI;
using WindowsFormsApp1.ExtensionMethods;

namespace WindowsFormsApp1
{
    public class SeleniumGetMethods
    {
        //Lösung 1 => besser ist jedoch Lösung 2 => noch besser Lösung 3

        //public static string GetText(IWebDriver driver, string element, string elementtype)
        //{
        //    if (elementtype == "Id")
        //        return driver.FindElement(By.Id(element)).GetAttribute("value");//For innerText use .Text() instead of .GettAttribute
        //    if (elementtype == "Name")
        //        return driver.FindElement(By.Name(element)).GetAttribute("value");
        //    else return String.Empty;
        //}

        //public static string GetTextFromDropDown(IWebDriver driver, string element, string elementtype)
        //{
        //    if (elementtype == "Id")
        //        return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
        //    if (elementtype == "Name")
        //        return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
        //    else return String.Empty;
        //}

        //Lösung 2
        //public static string GetText(string element, PropertyType elementtype)
        //{
        //    if (elementtype == PropertyType.Id)
        //        return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");//For innerText use .Text() instead of .GettAttribute
        //    if (elementtype == PropertyType.Name)
        //        return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
        //    else return String.Empty;
        //}

        //public static string GetTextFromDropDown(string element, PropertyType elementtype)
        //{
        //    if (elementtype == PropertyType.Id)
        //        return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
        //    if (elementtype == PropertyType.Name)
        //        return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
        //    else return String.Empty;
        //}

        //Lösung 3
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");        
        }

        public static string GetTextFromDropDown(IWebElement element)
        {            
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;           
        }
    }
}
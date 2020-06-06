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
    public static class SeleniumSetMethods
    {
        // Lösung 1 -> besser ist jedoch Lösung 2 (s. u.) -> noch besser ist Lösung 3 -> noch besser Lösung 4 mit ExtensionMethoden (dafür muss die class public class SeleniumSetMethods -> static werden -> public static class SeleniumSetMethods)

        //public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        //{
        //    if (elementtype == "Id")
        //        driver.FindElement(By.Id(element)).SendKeys(value);
        //    if (elementtype == "Name")
        //        driver.FindElement(By.Name(element)).SendKeys(value);
        //}

        //public static void Click(IWebDriver driver, string element, string elementtype)
        //{
        //    if (elementtype == "Id")
        //        driver.FindElement(By.Id(element)).Click();
        //    if (elementtype == "Name")
        //        driver.FindElement(By.Name(element)).Click();
        //}

        //public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        //{            
        //    if (elementtype == "Id")
        //        new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
        //    if (elementtype == "Name")
        //        new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        //}

        //Lösung 2
        //public static void EnterText(string element, string value, PropertyType elementtype)
        //{
        //    if (elementtype == PropertyType.Id)
        //        PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
        //    if (elementtype == PropertyType.Name)
        //        PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        //}

        //public static void Click(string element, PropertyType elementtype)
        //{
        //    if (elementtype == PropertyType.Id)
        //        PropertiesCollection.driver.FindElement(By.Id(element)).Click();
        //    if (elementtype == PropertyType.Name)
        //        PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        //}

        //public static void SelectDropDown(string element, string value, PropertyType elementtype)
        //{
        //    if (elementtype == PropertyType.Id)
        //        new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
        //    if (elementtype == PropertyType.Name)
        //        new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        //}

        //Lösung 3
        //public static void EnterText(IWebElement element, string value)
        //{
        //   element.SendKeys(value);
        //}

        //public static void Click(IWebElement element)
        //{
        //   element.Click();
        //}

        //public static void SelectDropDown(IWebElement element, string value)
        //{
        //    new SelectElement(element).SelectByText(value);
        //}

        //Lösung 4
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void Clicks(this IWebElement element) //Methodennamen geändert click to clicks
        {
            element.Click();
        }

        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
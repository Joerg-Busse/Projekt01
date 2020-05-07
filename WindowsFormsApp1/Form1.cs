using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.google.de/");
            Thread.Sleep(2000);

            IWebElement ele = driver.FindElement(By.Name("q"));
            ele.SendKeys("triebwerk duisburg");
            Thread.Sleep(2000);

            IWebElement eleBtn = driver.FindElement(By.Name("btnK"));
            eleBtn.Click();
            Thread.Sleep(2000);

            driver.Close();
        }
    }
}

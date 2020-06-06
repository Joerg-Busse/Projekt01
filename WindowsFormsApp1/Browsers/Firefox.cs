using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Selenium;

namespace WindowsFormsApp1.Browsers
{
    public class Firefox : IWebDriver
    {
        public void FindElement()
        {
            string s = "Find the Firefox UI Element";
        }

        public void Click()
        {
            string s = "Click the Firefox Element";
        }

        public void SendKeys(string keys)
        {
            string s = "Send the text for Firefox : " + keys;
        }
    }
}

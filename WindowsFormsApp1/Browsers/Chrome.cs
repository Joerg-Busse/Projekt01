using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Selenium;

namespace WindowsFormsApp1.Browsers
{
    class Chrome : IWebDriver
    {
        public void FindElement()
        {
            string s = "Find the Chrome UI Element";
        }

        public void Click()
        {
            string s = "Click the Chrome Element";
        }

        public void SendKeys(string keys)
        {
            string s = "Send the text for Chrome : " + keys;
        }        
    }
}

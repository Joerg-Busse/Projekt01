using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Selenium;

namespace WindowsFormsApp1.Browsers
{
    class IE : IWebDriver
    {
        public void FindElement()
        {
            string s = "Find the IE UI Element";
        }

        public void Click()
        {
            string s = "Click the IE Element";
        }

        public void SendKeys(string keys)
        {
            string s = "Send the text for IE : " + keys;
        }
    }
}

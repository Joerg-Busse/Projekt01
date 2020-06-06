﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Selenium
{
    public interface IWebDriver
    {
        void FindElement();

        void Click();

        void SendKeys(string keys);       
    }
}

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
using WindowsFormsApp1.Browsers;
using WindowsFormsApp1.Selenium;
using WindowsFormsApp1.ExtensionMethods;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    //das ist ein Testkommentar
    enum Browser
    {
        Firefox,
        Chrome,
        IE
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            // !!!!! https://www.youtube.com/watch?v=mluLgBywW0Y&list=PL6tu16kXT9PqKSouJUV6sRVgmcKs-VCqo&index=1 
            //IWebDriver driver = new Firefox();
            //driver.SendKeysWithSplChar("eins", "zwei");
            //NUnitScriptTest nunittest = new NUnitScriptTest();
            //nunittest.Initialize();
        }
    }
}

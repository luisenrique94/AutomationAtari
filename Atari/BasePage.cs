using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atari
{
   public class BasePage
    {
        public WebDriverWait Wait { get; set; }
        public IWebDriver Driver { get; set; }
        public BasePage(IWebDriver webDriver)
        {
            Wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(60));
            Driver =webDriver;
        }
    }
}

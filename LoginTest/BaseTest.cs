using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTest
{
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }
        public BaseTest()
        {
           InitializeTest();
        }
        public void InitializeTest()
        {
            Driver = new ChromeDriver();
           // Driver=new FirefoxDriver();
        }
       public void IrAtari()
        {
            try
            {
                Driver.Navigate().GoToUrl("http://191.232.161.185/#/login");
            }
            catch (Exception)
            {

                Console.Write("Tiempo de carga superado");
            }
        }
    }

        }
    

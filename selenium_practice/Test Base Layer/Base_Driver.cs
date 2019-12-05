using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using selenium_practice.Environment_Layer;

namespace selenium_practice.Test_Base_Layer
{
    public class Base_Driver
    {
        public enum WebBrowser
        {
            chrome,
            firefox,
        }
        public static IWebDriver driver;

        public static IWebDriver CreateWebDriver(WebBrowser browser)
        {
            switch (browser)
            {
                case WebBrowser.chrome:
                    driver = new ChromeDriver();
                    driver.Navigate().GoToUrl(Enviornment.URL);
                    Maximixe_Browser();
                    break;
                case WebBrowser.firefox:
                    driver = new FirefoxDriver();
                    break;
            }
            return driver;
        }
        public static void implictwait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        public static void Maximixe_Browser()
        {

            driver.Manage().Window.Maximize();

        }
        public static void Quit()
        {
            driver.Quit();
        }
    }
}

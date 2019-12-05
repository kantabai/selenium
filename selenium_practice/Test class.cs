using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace selenium_practice
{
   public class Test_class
    {

        public void doaction()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/");
            driver.FindElement(By.XPath("//button[text()='Sign In']")).Click();
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using selenium_practice.Test_Base_Layer;
using System;

namespace selenium_practice.Page_Layer
{
    public class TestUI
    {
        private static IWebDriver driver;
        internal TestUI()
        {

            driver = Base_Driver.CreateWebDriver(Base_Driver.WebBrowser.chrome);
            PageFactory.InitElements(driver,this);

        }
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email id for Sign Up']")]
        public IWebElement Emailid_forsignup { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@src='enter.png']")]
        private IWebElement enter_img { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@src='original.png']")]
        private IWebElement logo { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[text()='Sign In']")]
        private IWebElement sign_in { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Skip Sign In')]")]
        private IWebElement Skip_Sign_In { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='email']")]
        private IWebElement emailid_textbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Provide a valid email id for further updates')]")]
        private IWebElement span_text { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='imagesrc']")]
        private IWebElement uploadcontrol { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='radio' and @value='Male']")]
        private IWebElement male_gender { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @value='Cricket']")]
        private IWebElement cricket { get; set; }
        [FindsBy(How = How.XPath, Using = "//select[@type='text' and @id='Skills']")]
        private IWebElement skills { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@class='select2-selection select2-selection--single']")]
        private IWebElement select_country { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='select2-results__options']")]
        private IWebElement list_item { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='select2-search__field']")]
        private IWebElement country_textbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[text()='SwitchTo']")]
        private IWebElement switchto_text { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Alerts']")]
        private IWebElement Alerttext { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-danger']")]
        private IWebElement click_to_getalert { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Alert with OK & Cancel')]")]
        private IWebElement Alert_ok_cancel { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'click the button to display a confirm box')]")]
        private IWebElement alertwithtwo_btn { get; set; }

        [FindsBy(How=How.Id,Using = "demo")]
        private IWebElement alertpressed_text { get; set; }
        [FindsBy(How=How.XPath,Using = "//a[contains(text(),'Alert with Textbox ')]")]
        private IWebElement alertwith_textbox { get; set; }
        [FindsBy(How=How.XPath,Using = "//button[contains(text(),'click the button to demonstrate the prompt box')]")]
        private IWebElement buttonalert { get; set; }
        [FindsBy(How = How.Id, Using = "demo1")]
        private IWebElement alertpressed_text1 { get; set; }
        [FindsBy(How=How.XPath,Using = "//a[contains(text(),'Windows')]")] 
        private IWebElement windowhyperlink { get; set; }

        [FindsBy(How=How.XPath,Using = "//button[@class='btn btn-info' and text()='    click   ']")]
        private IWebElement firstwindowbtn { get; set; }
        [FindsBy(How=How.XPath,Using = "//a[contains(text(),'Open New Seperate Windows')]")]
        private IWebElement btn_Open_New_Seperate_Windows { get; set;}

        [FindsBy(How=How.XPath,Using = "//button[contains(text(),'click') and @class='btn btn-primary']")]
        private IWebElement click_btn_window { get; set; }
        [FindsBy(How=How.XPath,Using = "//a[contains(text(),'Open Seperate Multiple Windows') and @class='analystic']")]
        private IWebElement btn_Open_Seperate_Multiple_Windows { get; set; }

        [FindsBy(How=How.XPath,Using = "//a[contains(text(),'Frames')]")]
        private IWebElement Framelink { get; set; }

        [FindsBy(How=How.XPath,Using = "//input[@type='text']")]
        private IWebElement textbox { get; set; }

        [FindsBy(How=How.XPath,Using = "//a[text()='Iframe with in an Iframe']")]
        private IWebElement iframe_within_iframe { get; set; }

        public void do_action()
        {

            string value = "nirmal.chakraborty79@yahoo.com";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("arguments[0].value='" + value + "';", Emailid_forsignup);
        }
        public void Click_signin()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", Skip_Sign_In);
            string pagetitle = js.ExecuteScript("return document.title;").ToString();
            Console.WriteLine(pagetitle);
        }
        public void Move_to_registration()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", Skip_Sign_In);
        }
        public void gettooltip()
        {
            Move_to_registration();
            Actions act = new Actions(driver);
            act.MoveToElement(emailid_textbox).Build().Perform();
            bool isdisplayed = span_text.Displayed;
            if (isdisplayed == false)
            {
                new ElementNotVisibleException();
            }
            if (isdisplayed == true)
            {
                string text = span_text.Text;

                Console.WriteLine(text);
            }
        }
        public void upload_file_sendkey()
        {
            Move_to_registration();
            uploadcontrol.SendKeys(@"C:\Users\Nirmal_C\Desktop\xpath.txt");
        }
        public void malegender()
        {
            Move_to_registration();
            bool value = male_gender.Selected;
            if (!value)
            {
                male_gender.Click();
                string gettext = male_gender.Text;
                Console.WriteLine(gettext);
            }
        }
        public void cricket_checkbox()
        {
            Move_to_registration();
            bool value = cricket.Selected;
            if (!value)
            {
                cricket.Click();
                string gettext = cricket.Text;
                Console.WriteLine(gettext);
            }
        }
        public void selectskill()
        {
            Move_to_registration();
            SelectElement select = new SelectElement(skills);
            select.SelectByText("C++");
        }
        public void selectcountry()
        {
            Move_to_registration();
            select_country.Click();
        }
        public void getdata()
        {
            selectcountry();
            country_textbox.SendKeys("a");
            IList<IWebElement> getdata = driver.FindElements(By.XPath("//span[@class='select2-selection__rendered']"));

        }
        public void do_action_on_alert()
        {
            Move_to_registration();
            Actions act = new Actions(driver);
            act.MoveToElement(switchto_text).Build().Perform();
            Alerttext.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            click_to_getalert.Click();
            IAlert alert = driver.SwitchTo().Alert();
            string text = alert.Text;
            Console.WriteLine(text);
            alert.Accept();

        }
        public void alertok_cancel()
        {
            Move_to_registration();
            Actions act = new Actions(driver);
            act.MoveToElement(switchto_text).Build().Perform();
            Alerttext.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Alert_ok_cancel.Click();
            alertwithtwo_btn.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();
            string text = alertpressed_text.Text;
            Console.WriteLine(text);
        }

        public void Alert_with_textbox()
        {
            Move_to_registration();
            Actions act = new Actions(driver);
            act.MoveToElement(switchto_text).Build().Perform();
            Alerttext.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            alertwith_textbox.Click();
            buttonalert.Click();
            
            driver.SwitchTo().Alert().SendKeys("Hi");
            driver.SwitchTo().Alert().Accept();
            string gettext = alertpressed_text1.Text;
            Console.WriteLine(gettext);
            driver.Quit();
        }

        public void do_action_window()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Move_to_registration();
            Actions act = new Actions(driver);
            act.MoveToElement(switchto_text).Build().Perform();
            windowhyperlink.Click();
            firstwindowbtn.Click();
            act.SendKeys(Keys.Control + Keys.Tab);
        }
        public void open_new_window()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Move_to_registration();
            Actions act = new Actions(driver);
            act.MoveToElement(switchto_text).Build().Perform();
            windowhyperlink.Click();
            btn_Open_New_Seperate_Windows.Click();
            click_btn_window.Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Close();
        }
         public void Open_Multiple_Windows()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Move_to_registration();
            Actions act = new Actions(driver);
            act.MoveToElement(switchto_text).Build().Perform();
            windowhyperlink.Click();
            btn_Open_Seperate_Multiple_Windows.Click();
            click_btn_window.Click();
        }

        public void do_action_on_frame()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Move_to_registration();
            Actions act = new Actions(driver);
            act.MoveToElement(switchto_text).Build().Perform();
            Framelink.Click();
            driver.SwitchTo().Frame("singleframe");
            textbox.SendKeys("Rv is back shona");
            driver.SwitchTo().DefaultContent();
            iframe_within_iframe.Click();
            IReadOnlyCollection<IWebElement> framecount = driver.FindElements(By.TagName("iframe"));

            
            //driver.SwitchTo().Frame(1);
            //driver.SwitchTo().Frame(2);
            //textbox.SendKeys("Rv is on now racing track shona");

        }

    }
}

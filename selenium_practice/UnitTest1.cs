using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using selenium_practice.Page_Layer;

namespace selenium_practice
{
    [TestClass]
    public class UnitTest1
    {
        TestUI obj = new TestUI();
        
        [TestMethod]
        public void TestMethod1()
        {

            obj.do_action();
        }
        [TestMethod]
        public void Click_signin()
        {
            obj.Click_signin();
        }
        [TestMethod]
        public void Move_to_registration()
        {
            obj.Move_to_registration();
        }
        [TestMethod]
        public void gettooltip()
        {
            obj.gettooltip();
        }
        [TestMethod]
        public void upload_file_sendkey()
        {
            obj.upload_file_sendkey();
        }
        [TestMethod]
        public void malegender()
        {
            obj.malegender();
        }
        [TestMethod]
        public void select_skills()
        {
            obj.selectskill();
        }
        [TestMethod]
        public void selectcountry()
        {
            obj.selectcountry();
        }
        [TestMethod]
        public void getdata()
        {
            obj.getdata();
        }
        [TestMethod]
        public void do_action_on_alert()
        {
            obj.do_action_on_alert();
        }
        [TestMethod]
        public void alertok_cancel()
        {
            obj.alertok_cancel();
        }
        [TestMethod]
        public void Alert_with_textbox()
        {
            obj.Alert_with_textbox();
        }
        [TestMethod]
        public void Do_action_window()
        {
            obj.do_action_window();
        }

        [TestMethod]
        public void Open_new_window()
        {
            obj.open_new_window();
        }
        [TestMethod]
        public void Do_action_frame()
        {
            obj.do_action_on_frame();
        }
    }
}

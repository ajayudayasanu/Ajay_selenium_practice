using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_console2
{
   
    class LoginPageObjects
    {
        public LoginPageObjects()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }


        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtxPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObjects login(string UserName, String password)
        {
            txtUserName.SendKeys(UserName);
            txtxPassword.SendKeys(password);
            btnLogin.Submit();
            return new EAPageObjects();
        }
    }

   
}

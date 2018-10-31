using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_console2
{
    class EAPageObjects
    {
        public EAPageObjects()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.Id,Using ="TitleId")]
        public IWebElement ddlTitleID { get; set; }

        [FindsBy(How = How.Name,Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string Initial, string Firstname,string MiddleName)
        {
            //extened metod, we used this key word in the set metos
            txtInitial.EnterText(Initial);
            txtFirstName.EnterText(Firstname);
            txtMiddleName.EnterText(MiddleName);
            btnSave.Click();

            // before we making the set metod to static and before using this key word before iwebelement
            //seleniumsetmethods.EnterText(txtInitial, Initial);
            //seleniumsetmethods.EnterText(txtFirstName, Firstname);
            //seleniumsetmethods.EnterText(txtMiddleName, MiddleName);
            //seleniumsetmethods.Click(btnSave);

            //txtInitial.SendKeys(Initial);
            //txtFirstName.SendKeys(Firstname);
            //txtMiddleName.SendKeys(MiddleName);
            //btnSave.Click();
        }

    }
   
}

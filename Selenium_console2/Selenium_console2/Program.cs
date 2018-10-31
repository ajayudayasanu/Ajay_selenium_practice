using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Selenium_console2
{
    class Program
    {
        
        static void Main(string[] args)
        {
        
                   
        }
        [SetUp]
        public void initialize()
        {
            PropertyCollection.driver = new ChromeDriver();
            PropertyCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }
        [Test]
        public void executetest()
        {
            ExcelLib.PopulateInCollection(@"C:\Users\Ajay U\Desktop\My learning\Selenium\Testdata.xlsx");
            LoginPageObjects PageLogin = new LoginPageObjects();
            EAPageObjects PageEA = PageLogin.login(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));
            PageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));



            //EAPageObjects page = new EAPageObjects();

            //page.txtInitial.SendKeys("ajay");
            //page.btnSave.Click();


            //seleniumsetmethods.dropdown("TitleId", "Mr.", PropertyType.Id);
            //Console.WriteLine("drop down seleted");
            //seleniumsetmethods.EnterText("Initial", "ajay", PropertyType.Name);
            //Console.WriteLine("initial given");
            //seleniumsetmethods.Click( "Save",PropertyType.Name);
            //Console.WriteLine("Clicked save button");

            ////getting the values
            //Console.WriteLine("the input given in the dropdown is:" + SeleniumGetmethods.GetTextFromDOL( "TitleId", PropertyType.Id));
            //Console.WriteLine("the input given in the text field is :" + SeleniumGetmethods.GetText( "Initial", PropertyType.Id));
        }
        [TearDown]
        public void clearnup()
        {
            PropertyCollection.driver.Close();
        }
    }
}

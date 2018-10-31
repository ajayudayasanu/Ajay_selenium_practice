using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_console2
{
    
   public static class seleniumsetmethods
    {
        // for text, this is a extened method
     public static void EnterText( this IWebElement element ,string value)
        {
            element.SendKeys(value);
            //if (elementtype == PropertyType.Id)
            //    PropertyCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            //if (elementtype == PropertyType.Name)
            //    PropertyCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }
        // for click operation
        public static void Click(this IWebElement element)
        {
            element.Click();

            //    if (elementtype == PropertyType.Id)
            //        PropertyCollection.driver.FindElement(By.Id(element)).Click();
            //    if (elementtype == PropertyType.Name)
            //        PropertyCollection.driver.FindElement(By.Name(element)).Click();
            //}
            //for dropdown
        }
        public static void dropdown(this IWebElement element, string value )
        {
                new SelectElement(element).SelectByText(value);
            //if (elementtype == PropertyType.Id)
            //   new SelectElement(PropertyCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            //if (elementtype == PropertyType.Name)
            //    new SelectElement(PropertyCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}

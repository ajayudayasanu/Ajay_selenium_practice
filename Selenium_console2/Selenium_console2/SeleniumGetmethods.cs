using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_console2
{
    class SeleniumGetmethods
    {
        public static string GetText( IWebElement element)
        {
            return element.GetAttribute("value");
            //if (elementtype == PropertyType.Id)
            //    return PropertyCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            //if (elementtype == PropertyType.Name)
            //    return PropertyCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            //else
            //    return string.Empty;
        }

        public static string GetTextFromDOL(IWebElement element,PropertyType elementtype)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;

            //if (elementtype == PropertyType.Id)
            //    return new SelectElement(PropertyCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            //if (elementtype == PropertyType.Name)
            //    return new SelectElement(PropertyCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            //else
            //    return string.Empty;

        }
    }
}

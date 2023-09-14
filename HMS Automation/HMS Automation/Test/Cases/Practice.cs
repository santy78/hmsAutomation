using Microsoft.VisualBasic;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class Practice
    {
        public  void ChoosePractice(IWebDriver driver)
        {
            //IWebDriver driver
            IWebElement element = driver.FindElement(By.XPath("(//div[@class='d-flex align-items-center ng-star-inserted'])[1]"));

            // Click the element
            element.Click();
        }
    }
}

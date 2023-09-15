using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class MyPatients
    {
        public void Patients(IWebDriver driver)
        {
            IWebElement myPatients = driver.FindElement(By.XPath("(//a[normalize-space()='MY PATIENTS'])[1]"));
            myPatients.Click();
        }
    }
}

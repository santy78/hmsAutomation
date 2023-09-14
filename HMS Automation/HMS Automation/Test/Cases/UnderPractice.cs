using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class UnderPractice
    {
       public void Practice(IWebDriver driver)
       {
            //IWebDriver driver
            IWebElement element = driver.FindElement(By.XPath("(//a[normalize-space()='PRACTICE'])[1]"));

            // Click the element

            element.Click();

            IWebElement Patientelement = driver.FindElement(By.XPath("//*[@id=\"pills-patient-tab\"]"));
            Patientelement.Click();

            IWebElement PatientCreate = driver.FindElement(By.XPath("//button[normalize-space()='Add Patient']"));
            PatientCreate.Click();
            IWebElement firstName = driver.FindElement(By.Id("mat-input-1"));
            firstName.SendKeys("Raj");
            IWebElement lastName = driver.FindElement(By.Id("mat-input-2"));
            lastName.SendKeys("Smith");
        }
    }
}

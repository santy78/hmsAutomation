using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class BillingReport
    {
        public void ReportOfBilling(IWebDriver driver)
        {
           /* IWebElement report = driver.FindElement(By.XPath("(//a[normalize-space()='REPORTS'])[1]"));
            report.Click();*/

            IWebElement billingReport = driver.FindElement(By.XPath("(//li[@role='tab'])[2]"));
            billingReport.Click();
            
        }
    }
}

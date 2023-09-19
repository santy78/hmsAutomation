using HMS_Automation.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class UnreachableReport
    {
        public static int SessionId;
        public void ReportOfUnreachable(IWebDriver driver)
        {
            HMSAutomationResult automationresult = new HMSAutomationResult();
            HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
            automationresult.BatchId = SessionId;
            automationresult.ScreenName = "Unreachable Report";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();

            try
            {
                // Find and click on the "servicetimeReport" element
                IWebElement servicetimeReport = driver.FindElement(By.XPath("(//li[@role='tab'])[5]"));
                servicetimeReport.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                automationresult.ResponseType = "PASS";
            }
            catch (NoSuchElementException ex)
            {
                // Handle the case where the element is not found
                Console.WriteLine("Element not found: " + ex.Message);
                automationresult.ResponseType = "FAIL";
                automationresult.Errors = ex.Message;
            }
            automationDBContext.SaveAutomationResult(automationresult);
        }
    }
}

using HMS_Automation.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class UnreachableReport
    {
        
        public void ReportOfUnreachable(IWebDriver driver, int SessionId)
        {
            HMSAutomationResult automationresult = new HMSAutomationResult();
            HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
            automationresult.BatchId = SessionId;
            automationresult.ScreenName = "UNREACHABLE REPORT";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                // Find and click on the "servicetimeReport" element
                IWebElement servicetimeReport = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//li[@role='tab'])[5]")));
                servicetimeReport.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                automationresult.ResponseType = "PASS";
            }
            catch (NoSuchElementException e)
            {
                // Handle the case when the element is not found
                Console.WriteLine("Element not found: " + e.Message);
                automationresult.ResponseType = "FAIL";
                automationresult.Errors = e.Message;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
                automationresult.ResponseType = "FAIL";
                automationresult.Errors = ex.Message;
            }
            automationDBContext.SaveAutomationResult(automationresult);
        }
    }
}

using HMS_Automation.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class TrainingReport
    {
        public static int SessionId;
        public void ReportOfTraining(IWebDriver driver)
        {
           
            HMSAutomationResult automationresult = new HMSAutomationResult();
            HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
            automationresult.BatchId = SessionId;
            automationresult.ScreenName = "Training Report";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();

            try
            {
                // Find and click on the "REPORTS" element
                IWebElement report = driver.FindElement(By.XPath("(//a[normalize-space()='REPORTS'])[1]"));
                report.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                // Find and click on the "trainingReport" element
                IWebElement trainingReport = driver.FindElement(By.XPath("(//li[@role='tab'])[1]"));
                trainingReport.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                automationresult.ResponseType = "PASS";
            }
            catch (NoSuchElementException ex)
            {
                // Handle the case where the element is not found
                Console.WriteLine("Element not found: " + ex.Message);
                automationresult.ResponseType = "FAIL";
                automationresult.Errors = ex.Message;
            }

        }
    }
}

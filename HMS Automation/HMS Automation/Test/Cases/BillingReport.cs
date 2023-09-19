using HMS_Automation.Model;
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
        public void ReportOfBilling(IWebDriver driver,int SessionId)
        {
            HMSAutomationResult automationresult = new HMSAutomationResult();
            HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
            automationresult.BatchId = SessionId;
            automationresult.ScreenName = "REPORTS-99454";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();

            try
            {
                /* IWebElement report = driver.FindElement(By.XPath("(//a[normalize-space()='REPORTS'])[1]"));
                 report.Click();*/
                //IWebElement report = driver.FindElement(By.XPath(" //i[@class='fas fa-angle-down rotate-icon']"));
                // report.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement billingReport = driver.FindElement(By.XPath("(//a[normalize-space()='99454'])[1]"));
                billingReport.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                automationresult.ResponseType = "PASS";
            }
            catch (Exception ex)
            {
             
                automationresult.Errors = ex.Message;
                automationresult.ResponseType = "FAIL";
            }

            var database = automationDBContext.SaveAutomationResult(automationresult);
        }



    }
}

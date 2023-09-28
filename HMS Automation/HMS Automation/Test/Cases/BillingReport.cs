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
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                /* IWebElement report = driver.FindElement(By.XPath("(//a[normalize-space()='REPORTS'])[1]"));
                 report.Click();*/
                //IWebElement report = driver.FindElement(By.XPath(" //i[@class='fas fa-angle-down rotate-icon']"));
                // report.Click();
                
                IWebElement billingReport = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//a[normalize-space()='99454'])[1]")));
                billingReport.Click();
             
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

            var database = automationDBContext.SaveAutomationResult(automationresult);
        }



    }
}

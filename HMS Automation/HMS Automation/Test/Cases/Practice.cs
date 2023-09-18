using HMS_Automation.Model;
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
        public static int SessionId;
        public  void ChoosePractice(IWebDriver driver)
        {
            SessionId = HMSAutomationDBContext.GetBatchID();
            HMSAutomationResult automationresult = new HMSAutomationResult();
            HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
            automationresult.BatchId = SessionId;
            automationresult.ScreenName = "PRACTICE";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();
            try
            {
                //IWebDriver driver
                IWebElement element = driver.FindElement(By.XPath("//h4[normalize-space()='Rajesh Test']"));

                // Click the element
                element.Click();
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
            automationDBContext.SaveAutomationResult(automationresult);
        }
    }
}

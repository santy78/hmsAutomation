using HMS_Automation.Model;
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
        public static int SessionId;
        public void Patients(IWebDriver driver)
        {

            HMSAutomationResult automationresult = new HMSAutomationResult();
            HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
            automationresult.BatchId = SessionId;
            automationresult.ScreenName = "PATIENTS";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();
            try
            {
                IWebElement myPatients = driver.FindElement(By.XPath("(//a[normalize-space()='MY PATIENTS'])[1]"));
                myPatients.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                automationresult.ResponseType = "PASS";
            }
            catch (NoSuchElementException ex)
            {
                // Handle the case where the element is not found
                Console.WriteLine("Element not found: " + ex.Message);
                automationresult.ResponseType = "FAIL";
                automationresult.Errors = e.Message;
            }
            automationDBContext.SaveAutomationResult(automationresult);



        }
    }
}

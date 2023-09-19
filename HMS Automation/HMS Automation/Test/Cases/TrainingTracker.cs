using HMS_Automation.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class TrainingTracker
    {
        public static int SessionId;
        public void Training(IWebDriver driver)
        {
            SessionId = HMSAutomationDBContext.GetBatchID();
            HMSAutomationResult automationresult = new HMSAutomationResult();
            HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
            automationresult.BatchId = SessionId;
            automationresult.ScreenName = "PATIENT TRAINING";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();
            try
            {
                //training tracker screen

                IWebElement training = driver.FindElement(By.XPath("(//a[normalize-space()='TRAINING TRACKER'])[1]"));
            training.Click();

            //action
            
            IWebElement action = driver.FindElement(By.XPath("//mat-icon[normalize-space()='more_horiz']"));
            action.Click();

            IWebElement scheduleTraining = driver.FindElement(By.XPath("(//button[normalize-space()='Schedule Training'])[1]"));
            scheduleTraining.Click();

            //submit Schedule Training

            IWebElement submit = driver.FindElement(By.XPath("(//button[@class='mat-focus-indicator accept-btn px-5 confirmation-text rounded-0 mat-button mat-button-base ng-star-inserted'])[1]"));
            submit.Click();

                //To complete Training 

                //action
            Thread.Sleep(TimeSpan.FromSeconds(5));
            IWebElement actionForComplete = driver.FindElement(By.XPath("//mat-icon[normalize-space()='more_horiz']"));
            actionForComplete.Click();

            IWebElement completeTraining = driver.FindElement(By.XPath("(//button[normalize-space()='Mark Training Complete'])[1]"));
            completeTraining.Click();

            //submit complete Training

            IWebElement finalSubmit = driver.FindElement(By.XPath("(//button[@class='mat-focus-indicator accept-btn confirmation-text rounded-0 mat-stroked-button mat-button-base'])[1]"));
             finalSubmit.Click();
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

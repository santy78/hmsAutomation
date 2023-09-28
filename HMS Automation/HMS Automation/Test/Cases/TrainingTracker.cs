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
    internal class TrainingTracker
    {
        
        public void Training(IWebDriver driver, int SessionId)
        {
           
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
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                IWebElement training = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//a[normalize-space()='TRAINING TRACKER'])[1]")));
                
                training.Click();
               

                //action

                IWebElement action = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-icon[normalize-space()='more_horiz']")));
                action.Click();
            

                IWebElement scheduleTraining = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//button[normalize-space()='Schedule Training'])[1]")));
                scheduleTraining.Click();
                

                //submit Schedule Training

                IWebElement submit = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//button[@class='mat-focus-indicator accept-btn px-5 confirmation-text rounded-0 mat-button mat-button-base ng-star-inserted'])[1]")));
                submit.Click();
                

                //To complete Training 

                //action
               
                IWebElement actionForComplete = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-icon[normalize-space()='more_horiz']")));
                actionForComplete.Click();
           

                IWebElement completeTraining = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//button[normalize-space()='Mark Training Complete'])[1]")));
                completeTraining.Click();
               

                //submit complete Training

                IWebElement finalSubmit = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//button[@class='mat-focus-indicator accept-btn confirmation-text rounded-0 mat-stroked-button mat-button-base'])[1]")));
               finalSubmit.Click();
          

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

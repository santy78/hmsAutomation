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
        public void Training(IWebDriver driver)
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

            IWebElement actionForComplete = driver.FindElement(By.XPath("//mat-icon[normalize-space()='more_horiz']"));
            actionForComplete.Click();

            IWebElement completeTraining = driver.FindElement(By.XPath("(//button[normalize-space()='Mark Training Complete'])[1]"));
            completeTraining.Click();

            //submit complete Training

            IWebElement finalSubmit = driver.FindElement(By.XPath("(//button[@class='mat-focus-indicator accept-btn confirmation-text rounded-0 mat-stroked-button mat-button-base'])[1]"));
            finalSubmit.Click();
        }

    }
}

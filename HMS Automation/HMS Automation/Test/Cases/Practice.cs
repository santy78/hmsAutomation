using HMS_Automation.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace HMS_Automation.Test.Cases
{
    internal class Practice
    {
        public void ChoosePractice(IWebDriver driver, int SessionId)
        {
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
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement practiceInput = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"mat-input-0\"]")));

                // Click the input field
                practiceInput.Click();

                // Send keys to the input field
               // practiceInput.SendKeys(Constants.practice);

                // Wait for the practice list element to be clickable
                IWebElement practiceListElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/app-practicelist/div[2]/div")));

                // Click the practice list element
                practiceListElement.Click();

                // Set ResponseType to "PASS" if successful
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

            // Save the automation result to the database
            automationDBContext.SaveAutomationResult(automationresult);
        }
    }
}

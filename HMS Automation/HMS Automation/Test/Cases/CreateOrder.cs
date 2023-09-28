using HMS_Automation.Model;
using Microsoft.VisualBasic;
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
    internal class CreateOrder
    {
        
        public void Order(IWebDriver driver, int SessionId)
        {
           
            HMSAutomationResult automationresult = new HMSAutomationResult();
            HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
            automationresult.BatchId = SessionId;
            automationresult.ScreenName = "CREATE ORDER";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();
            try
            {
                //createorder screen
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                IWebElement order = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//a[normalize-space()='CREATE ORDER'])[1]")));
                order.Click();
          

                //action

                IWebElement action = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-icon[normalize-space()='more_horiz']")));
                action.Click();
            

                IWebElement createOrder = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//button[normalize-space()='Create Order'])[1]")));
                createOrder.Click();
                

                //device

                IWebElement device = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("mat-select-placeholder")));
                device.Click();
               
                IWebElement selectDevice = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//span[normalize-space()='Blood Pressure Cuff'])[1]")));
                selectDevice.Click();
               

                //deviceType

                IWebElement deviceType = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("mat-select-placeholder")));
                deviceType.Click();
          
                IWebElement selectDeviceType = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//span[@class='mat-option-text'])[1]")));
                selectDeviceType.Click();
               

                //submit order

                IWebElement orderSubmit = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//button[@class='mat-focus-indicator accept-btn px-5 confirmation-text rounded-0 mat-button mat-button-base ng-star-inserted'])[1]")));
                orderSubmit.Click();

                //successfull
                
                IWebElement orderSuccessfull = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".text-end.position-absolute")));
               
                orderSuccessfull.Click();

          
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

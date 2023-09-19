using HMS_Automation.Model;
using Microsoft.VisualBasic;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class CreateOrder
    {
        public static int SessionId;
        public void Order(IWebDriver driver)
        {
            SessionId = HMSAutomationDBContext.GetBatchID();
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
                Thread.Sleep(TimeSpan.FromSeconds(5));

                IWebElement order = driver.FindElement(By.XPath("(//a[normalize-space()='CREATE ORDER'])[1]"));
            order.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));

                //action

                IWebElement action = driver.FindElement(By.XPath("//mat-icon[normalize-space()='more_horiz']"));
            action.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));

                IWebElement createOrder = driver.FindElement(By.XPath("(//button[normalize-space()='Create Order'])[1]"));
            createOrder.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));

                //device

                IWebElement device = driver.FindElement(By.ClassName("mat-select-placeholder"));
            device.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));

                IWebElement selectDevice = driver.FindElement(By.XPath("(//span[normalize-space()='Blood Pressure Cuff'])[1]"));
            selectDevice.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));

                //deviceType

                IWebElement deviceType = driver.FindElement(By.ClassName("mat-select-placeholder"));
            deviceType.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement selectDeviceType = driver.FindElement(By.XPath("(//span[@class='mat-option-text'])[1]"));
            selectDeviceType.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));

                //submit order

                IWebElement orderSubmit = driver.FindElement(By.XPath("(//button[@class='mat-focus-indicator accept-btn px-5 confirmation-text rounded-0 mat-button mat-button-base ng-star-inserted'])[1]"));
            orderSubmit.Click();

                //successfull
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement orderSuccessfull = driver.FindElement(By.XPath("(//mat-icon[normalize-space()='cancel'])[1]"));
            orderSuccessfull.Click();
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

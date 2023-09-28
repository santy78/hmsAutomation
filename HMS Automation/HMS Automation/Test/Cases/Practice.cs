using HMS_Automation.Model;
using Microsoft.VisualBasic;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HMS_Automation.Test.Cases
{
    internal class Practice
    {
        
        public  void ChoosePractice(IWebDriver driver, int SessionId)
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
                //IWebDriver driver
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement element = driver.FindElement(By.XPath("//*[@id=\"mat-input-0\"]"));

                // Click the element
                element.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                element.SendKeys(Constants.practice);
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement element1 = driver.FindElement(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/app-practicelist/div[2]/div"));
                element1.Click();
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

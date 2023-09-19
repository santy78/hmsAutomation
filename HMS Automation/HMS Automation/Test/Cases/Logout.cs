using HMS_Automation.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace HMS_Automation.Test.Cases
{
    internal class Logout
    {
        public void logout_click( IWebDriver driver, int SessionId)
        {
            HMSAutomationResult automationresult = new HMSAutomationResult();
            HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
            automationresult.BatchId = SessionId;
            automationresult.ScreenName = "LOGOUT";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();
            try
            {
                IWebElement element = driver.FindElement(By.XPath("//body/div[2]/div[1]"));
                element.Click();

                IWebElement logout = driver.FindElement(By.XPath("//body/div[2]/div[2]/div/div/div/button"));
                logout.Click();
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

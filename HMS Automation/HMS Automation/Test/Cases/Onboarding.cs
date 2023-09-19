using HMS_Automation.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class Onboarding
    {
        public static int SessionId;
        
        public void PatientOnboarding(IWebDriver driver)
        {

            SessionId = HMSAutomationDBContext.GetBatchID();
            HMSAutomationResult automationresult = new HMSAutomationResult();
            HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
            automationresult.BatchId = SessionId;
            automationresult.ScreenName = "PATIENT ONBOARDING";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();
            try
            {
                //IWebDriver driver
                IWebElement onboarding = driver.FindElement(By.XPath("(//a[normalize-space()='PATIENT ONBOARDING'])[1]"));

                // Click the element

                onboarding.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement action = driver.FindElement(By.XPath("//mat-icon[@role='button']"));
                action.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement verification = driver.FindElement(By.XPath("//button[normalize-space()='Update Verification Statuses']"));
                verification.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement checkbox1 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[1]"));
                checkbox1.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement checkbox2 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[2]"));
                checkbox2.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement checkbox3 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[3]"));
                checkbox3.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement checkbox4 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[4]"));
                
                checkbox4.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement checkbox5 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[5]"));
                checkbox5.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
               // IWebElement checkbox6 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[6]"));
               // checkbox6.Click();
               // Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement verify = driver.FindElement(By.XPath("//button[normalize-space()='Verify']"));
                verify.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement verbalconsent = driver.FindElement(By.XPath("//button[normalize-space()='Obtain Verbal Consent']"));
                verbalconsent.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement enrollment = driver.FindElement(By.XPath("//span[normalize-space()='YES']"));
                enrollment.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement qualifyRPM = driver.FindElement(By.XPath("//button[normalize-space()='Qualify For RPM']"));
                qualifyRPM.Click();
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

using HMS_Automation.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HMS_Automation.Test.Cases
{
    internal class Onboarding
    {
       
        
        public void  PatientOnboarding(IWebDriver driver, int SessionId, string RegisterLastName)
        {
            

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
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


                IWebElement onboarding = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//a[normalize-space()='PATIENT ONBOARDING'])[1]")));
              
                // Click the element

                onboarding.Click();
                
                IWebElement onboarding1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/app-root/app-home/div/mat-drawer-container/mat-drawer-content/app-onboarding/div/div[1]/app-search/div/div/div/div[1]/div/button/span[1]/span/mat-icon[2]")));
                onboarding1.Click();
                
                IWebElement lastname1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//input[@id='mat-input-2'])[1]")));
               
                lastname1.SendKeys(RegisterLastName);
                

                

             
                IWebElement submit = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/app-root/app-home/div/mat-drawer-container/mat-drawer-content/app-onboarding/div/div[1]/app-search/div/div/div/div[2]/div/form/div[2]/div[2]/button[1]")));
                submit.Click();
            
                IWebElement action = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-icon[@role='button']")));
                action.Click();
             
                IWebElement verification = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[normalize-space()='Update Verification Statuses']")));
                verification.Click();
               
                IWebElement checkbox1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//span[@class='mat-checkbox-inner-container'])[1]")));
                checkbox1.Click();
              
                IWebElement checkbox2 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//span[@class='mat-checkbox-inner-container'])[2]")));
                checkbox2.Click();
              
                IWebElement checkbox3 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//span[@class='mat-checkbox-inner-container'])[3]")));
                checkbox3.Click();
                
                IWebElement checkbox4 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//span[@class='mat-checkbox-inner-container'])[4]")));
                
                checkbox4.Click();
               
                IWebElement checkbox5 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//span[@class='mat-checkbox-inner-container'])[5]")));
                checkbox5.Click();
                
               // IWebElement checkbox6 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[6]"));
               // checkbox6.Click();
               // Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement verify = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[normalize-space()='Verify']")));
                verify.Click();
              
                IWebElement verbalconsent = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[normalize-space()='Obtain Verbal Consent']")));
              
                verbalconsent.Click();
          
                IWebElement enrollment = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[normalize-space()='YES']")));
                enrollment.Click();
        
                IWebElement qualifyRPM = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[normalize-space()='Qualify For RPM']")));
         
                qualifyRPM.Click();
           

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

using HMS_Automation.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HMS_Automation.Test.Cases
{
    internal class MyPatients
    {

        public void Patients(IWebDriver driver, int SessionId)
        {

            HMSAutomationResult automationresult = new HMSAutomationResult();
            HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
            automationresult.BatchId = SessionId;
            automationresult.ScreenName = "MY PATIENTS";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement myPatients = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//a[normalize-space()='MY PATIENTS'])[1]")));
               
                myPatients.Click();
               
                 IWebElement onClick = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/app-root/app-home/div/mat-drawer-container/mat-drawer-content/app-monitoring/div/div[2]/table/tbody/tr[1]/td[1]/div")));
                 onClick.Click();
               
                IWebElement call = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/app-root/app-home/div/mat-drawer-container/mat-drawer-content/app-monitoring/div/div[2]/table/tbody/tr[2]/td/div/div/div/div[2]/div/div[2]/div[1]/button")));
                 call.Click();
             

                 IWebElement select = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/div/div[2]/div/div[2]/form/div/div[1]/mat-form-field/div/div[1]/div/mat-select/div/div[2]")));
                 select.Click();
                 
                 IWebElement selectOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[normalize-space()='Hypertension']")));
                 selectOption.Click();
                
                 IWebElement readingOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/div/div[2]/div/div[2]/form/div/div[2]/mat-form-field/div/div[1]/div/mat-select/div/div[2]")));
                 readingOption.Click();
       
                 IWebElement readingType = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[normalize-space()='Critical']")));
                 readingType.Click();
              
                 IWebElement question = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/div/div[2]/div/div[2]/form/form/div/div[20]/section/mat-radio-group/mat-radio-button[2]/label/span[1]/span[1]")));
                 question.Click();
              
                 IWebElement submit = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/div/div[2]/div/div[2]/form/form/button")));
                 submit.Click();
   
                 IWebElement close = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='cdk-global-overlay-wrapper']")));
                 close.Click();
                  IWebElement cancel = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-icon[normalize-space()='cancel']")));
                 cancel.Click();

                 IWebElement email = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),'EMAIL')]")));
                 email.Click();
           
                 IWebElement send = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[normalize-space()='SEND']")));
                 send.Click();
              
                 //IWebElement cancel1 = driver.FindElement(By.XPath("//mat-icon[normalize-space()='cancel']"));
                 //cancel1.Click();
                 IWebElement addNotes = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),'ADD NOTES')]")));
                 addNotes.Click();
                
                 IWebElement addNotes1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(text(),'Add Notes')]")));
                 addNotes1.Click();
             
                 IWebElement notes1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("textArea")));

                 notes1.SendKeys(Constants.notes1);
                 IWebElement save = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[normalize-space()='Save']")));
                 save.Click();
            
                 IWebElement onClick1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/app-root/app-home/div/mat-drawer-container/mat-drawer-content/app-monitoring/div/div[2]/table/tbody/tr[1]/td[1]/div")));
                onClick1.Click();
            
                /*IWebElement profile = driver.FindElement(By.XPath("//body/app-root/app-home/div/mat-drawer-container/mat-drawer-content/app-monitoring/div/div[2]/table/tbody/tr[2]/td/div/div/div/div[1]/div/mat-card/div[1]/div[2]/div/div[1]/a"));
                profile.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement profile1 = driver.FindElement(By.XPath("//button[@id='pills-bpressure-tab']"));
                profile1.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));*/
                IWebElement alerts = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/app-root/app-home/div/mat-drawer-container/mat-drawer-content/app-monitoring/div/div[2]/table/tbody/tr[2]/td/div/div/div/div[2]/div/div[2]/div[6]/button")));
                alerts.Click();
             
               

               IWebElement cancel1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/div/div[1]/div/div[3]/mat-icon")));
                cancel1.Click();
              
                //(//button[normalize-space()='Action Log and Notes'])[1]

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

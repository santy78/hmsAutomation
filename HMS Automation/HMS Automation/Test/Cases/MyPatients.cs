using HMS_Automation.Model;
using OpenQA.Selenium;
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
            automationresult.ScreenName = "PATIENTS";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();
            try
            {
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement myPatients = driver.FindElement(By.XPath("(//a[normalize-space()='MY PATIENTS'])[1]"));
                Thread.Sleep(TimeSpan.FromSeconds(5));
                myPatients.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                 IWebElement onClick = driver.FindElement(By.XPath("//body/app-root/app-home/div/mat-drawer-container/mat-drawer-content/app-monitoring/div/div[2]/table/tbody/tr[1]/td[1]/div"));
                 onClick.Click();
                 Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement call = driver.FindElement(By.XPath("//body/app-root/app-home/div/mat-drawer-container/mat-drawer-content/app-monitoring/div/div[2]/table/tbody/tr[2]/td/div/div/div/div[2]/div/div[2]/div[1]/button"));
                 call.Click();
                 Thread.Sleep(TimeSpan.FromSeconds(5));

                 IWebElement select = driver.FindElement(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/div/div[2]/div/div[2]/form/div/div[1]/mat-form-field/div/div[1]/div/mat-select/div/div[2]"));
                 select.Click();
                 Thread.Sleep(TimeSpan.FromSeconds(5));
                 IWebElement selectOption = driver.FindElement(By.XPath("//span[normalize-space()='Hypertension']"));
                 selectOption.Click();
                 Thread.Sleep(TimeSpan.FromSeconds(5));
                 IWebElement readingOption = driver.FindElement(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/div/div[2]/div/div[2]/form/div/div[2]/mat-form-field/div/div[1]/div/mat-select/div/div[2]"));
                 readingOption.Click();
                 Thread.Sleep(TimeSpan.FromSeconds(5));
                 IWebElement readingType = driver.FindElement(By.XPath("//span[normalize-space()='Critical']"));
                 readingType.Click();
                 Thread.Sleep(TimeSpan.FromSeconds(5));
                 IWebElement question = driver.FindElement(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/div/div[2]/div/div[2]/form/form/div/div[20]/section/mat-radio-group/mat-radio-button[2]/label/span[1]/span[1]"));
                 question.Click();
                 Thread.Sleep(TimeSpan.FromSeconds(5));
                 IWebElement submit = driver.FindElement(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/div/div[2]/div/div[2]/form/form/button"));
                 submit.Click();
                 Thread.Sleep(TimeSpan.FromSeconds(5));
                 IWebElement close = driver.FindElement(By.XPath("//div[@class='cdk-global-overlay-wrapper']"));
                 close.Click();
                  IWebElement cancel = driver.FindElement(By.XPath("//mat-icon[normalize-space()='cancel']"));
                 cancel.Click();

                 IWebElement email = driver.FindElement(By.XPath("//button[contains(text(),'EMAIL')]"));
                 email.Click();
                 Thread.Sleep(TimeSpan.FromSeconds(5));
                 IWebElement send = driver.FindElement(By.XPath("//button[normalize-space()='SEND']"));
                 send.Click();
                 Thread.Sleep(TimeSpan.FromSeconds(5));
                 //IWebElement cancel1 = driver.FindElement(By.XPath("//mat-icon[normalize-space()='cancel']"));
                 //cancel1.Click();
                 IWebElement addNotes = driver.FindElement(By.XPath("//button[contains(text(),'ADD NOTES')]"));
                 addNotes.Click();
                 Thread.Sleep(TimeSpan.FromSeconds(5));
                 IWebElement addNotes1 = driver.FindElement(By.XPath("//a[contains(text(),'Add Notes')]"));
                 addNotes1.Click();
                 Thread.Sleep(TimeSpan.FromSeconds(5));
                 IWebElement notes1 = driver.FindElement(By.Id("textArea"));

                 notes1.SendKeys(Constants.notes1);
                 IWebElement save = driver.FindElement(By.XPath("//button[normalize-space()='Save']"));
                 save.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                 IWebElement onClick1 = driver.FindElement(By.XPath("//body/app-root/app-home/div/mat-drawer-container/mat-drawer-content/app-monitoring/div/div[2]/table/tbody/tr[1]/td[1]/div"));
                onClick1.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                /*IWebElement profile = driver.FindElement(By.XPath("//body/app-root/app-home/div/mat-drawer-container/mat-drawer-content/app-monitoring/div/div[2]/table/tbody/tr[2]/td/div/div/div/div[1]/div/mat-card/div[1]/div[2]/div/div[1]/a"));
                profile.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement profile1 = driver.FindElement(By.XPath("//button[@id='pills-bpressure-tab']"));
                profile1.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));*/
                IWebElement alerts = driver.FindElement(By.XPath("//body/app-root/app-home/div/mat-drawer-container/mat-drawer-content/app-monitoring/div/div[2]/table/tbody/tr[2]/td/div/div/div/div[2]/div/div[2]/div[6]/button"));
                alerts.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
               

               IWebElement cancel1 = driver.FindElement(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/div/div[1]/div/div[3]/mat-icon"));
                cancel1.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                //(//button[normalize-space()='Action Log and Notes'])[1]

                automationresult.ResponseType = "PASS";
            }
            catch (NoSuchElementException ex)
            {
                // Handle the case where the element is not found
                Console.WriteLine("Element not found: " + ex.Message);
                automationresult.ResponseType = "FAIL";
                automationresult.Errors = ex.Message;
            }
            automationDBContext.SaveAutomationResult(automationresult);



        }
    }
}

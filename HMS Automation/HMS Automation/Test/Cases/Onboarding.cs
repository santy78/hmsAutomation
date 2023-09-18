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
        public void PatientOnboarding(IWebDriver driver)
        {
            //IWebDriver driver
            IWebElement onboarding = driver.FindElement(By.XPath("(//a[normalize-space()='PATIENT ONBOARDING'])[1]"));

            // Click the element

            onboarding.Click();
            IWebElement action = driver.FindElement(By.XPath("//mat-icon[@role='button']"));
            action.Click();
            IWebElement verification = driver.FindElement(By.XPath("//button[normalize-space()='Update Verification Statuses']"));
            verification.Click();
            IWebElement checkbox1 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[1]"));
             checkbox1.Click();
            IWebElement checkbox2 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[2]"));
            checkbox2.Click();
            IWebElement checkbox3 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[3]"));
            checkbox3.Click();
            IWebElement checkbox4 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[4]"));
            checkbox4.Click();
            IWebElement checkbox5 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[5]"));
            checkbox5.Click();
            IWebElement checkbox6 = driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container'])[6]"));
            checkbox6.Click();
            IWebElement verify = driver.FindElement(By.XPath("//button[normalize-space()='Verify']"));
            verify.Click();
            IWebElement verbalconsent = driver.FindElement(By.XPath("//button[normalize-space()='Obtain Verbal Consent']"));
            verbalconsent.Click();
            IWebElement enrollment = driver.FindElement(By.XPath("//span[normalize-space()='YES']"));
            enrollment.Click();
            IWebElement qualifyRPM = driver.FindElement(By.XPath("//button[normalize-space()='Qualify For RPM']"));
            qualifyRPM.Click();
               

        }
    }
}

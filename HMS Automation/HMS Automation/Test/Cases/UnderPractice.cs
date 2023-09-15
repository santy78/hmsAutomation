using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class UnderPractice
    {
       public void Practice(IWebDriver driver)
       {
            //IWebDriver driver
            IWebElement element = driver.FindElement(By.XPath("(//a[normalize-space()='PRACTICE'])[1]"));

            // Click the element

            element.Click();

            IWebElement Patientelement = driver.FindElement(By.XPath("//*[@id=\"pills-patient-tab\"]"));
            Patientelement.Click();

            IWebElement PatientCreate = driver.FindElement(By.XPath("//button[normalize-space()='Add Patient']"));
            PatientCreate.Click();
            IWebElement firstName = driver.FindElement(By.Id("mat-input-1"));
            firstName.SendKeys("Raj");
            IWebElement lastName = driver.FindElement(By.Id("mat-input-2"));
            Random random = new Random();
            lastName.SendKeys("Smith"+ random.Next(100, 1000));
            IWebElement phoneNumber = driver.FindElement(By.Id("mat-input-3"));
            long randomNumber = random.Next(1000000, 1000000); // Generates a random number between 1,000,000,000 and 9,999,999,999

            phoneNumber.SendKeys("100"+randomNumber);

            IWebElement email=driver.FindElement(By.Id("mat-input-4"));
            email.SendKeys("Raj" + random.Next(100, 1000) + "@gmail.com");

            IWebElement genderDropdown = driver.FindElement(By.XPath("(//div[@class='mat-select-arrow-wrapper ng-tns-c56-19'])[1]"));
            genderDropdown.Click();

            IWebElement genderSelect = driver.FindElement(By.XPath("(//mat-option[@id='mat-option-0'])[1]"));
            genderSelect.Click();

            IWebElement dob = driver.FindElement(By.Id("dob"));
            dob.SendKeys("12-09-2000");

            IWebElement nextButton = driver.FindElement(By.XPath("(//button[@type='submit'][normalize-space()='Next'])[1]"));
            nextButton.Click();

            IWebElement Address1 = driver.FindElement(By.Id("mat-input-6"));
            Address1.SendKeys("USA");

            IWebElement city = driver.FindElement(By.Id("mat-input-8"));
            city.SendKeys("test");

            IWebElement stateDropDown = driver.FindElement(By.XPath("(//div[@class='mat-select-arrow ng-tns-c56-25'])[1]"));
            stateDropDown.Click();

            IWebElement state = driver.FindElement(By.XPath("(//mat-option[@id='mat-option-30'])[1]"));
            state.Click();
            IWebElement pin = driver.FindElement(By.Id("mat-input-9"));
            pin.SendKeys("78909");

            IWebElement nextClick = driver.FindElement(By.XPath(" (//button[@type='submit'][normalize-space()='Next'])[2]"));
            nextClick.Click();
           IWebElement skipButton = driver.FindElement(By.XPath("(//button[@class='mat-stepper-next btn ms-3 patient-form-reset-btn position-absolute reset-btn'])[1]"));
           skipButton.Click();
            IWebElement skipClick = driver.FindElement(By.XPath(" (//button[@class='btn ms-3 patient-form-reset-btn position-absolute reset-btn'])[1]"));
            skipClick.Click();
            IWebElement skip2Click= driver.FindElement(By.XPath("(//button[@class='mat-stepper-next btn ms-3 reset-btn'])[1]"));
            skip2Click.Click();
            IWebElement submit = driver.FindElement(By.XPath("(//button[normalize-space()='Submit'])[1]"));
            submit.Click();




        }
    }
}

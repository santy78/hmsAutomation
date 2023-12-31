﻿using Azure;
using HMS_Automation.DTOs;
using HMS_Automation.Model;
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

        public async Task<UnderPracticeResponse> Practice(IWebDriver driver, int SessionId,string RegisterLastName)
        {
            UnderPracticeResponse underPracticeResponse= new UnderPracticeResponse();
            
            HMSAutomationResult automationresult = new HMSAutomationResult();
            HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
            automationresult.BatchId = SessionId;
            automationresult.ScreenName = "ADD PATIENTS";
            automationresult.ResponseType = "";
            automationresult.Request = "";
            automationresult.Response = "";
            automationresult.Errors = "";
            automationresult.DateTime = DateTime.Now.ToString();
           
            try
            {
                //IWebDriver driver
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement element = driver.FindElement(By.XPath("(//a[normalize-space()='PRACTICE'])[1]"));
                Thread.Sleep(TimeSpan.FromSeconds(5));
                element.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement Patientelement = driver.FindElement(By.XPath("//*[@id=\"pills-patient-tab\"]"));
                Patientelement.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement PatientCreate = driver.FindElement(By.XPath("//button[normalize-space()='Add Patient']"));
                PatientCreate.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement firstName = driver.FindElement(By.Id("mat-input-1"));
                firstName.SendKeys(Constants.firstName);
                IWebElement lastName = driver.FindElement(By.Id("mat-input-2"));
                Random random = new Random();
             
                lastName.SendKeys(RegisterLastName);

                underPracticeResponse.LastName = RegisterLastName;
                
                IWebElement phoneNumber = driver.FindElement(By.Id("mat-input-3"));
                long randomNumber = random.Next(1000000, 1000000); // Generates a random number between 1,000,000,000 and 9,999,999,999

                phoneNumber.SendKeys("110" + randomNumber);

                IWebElement email = driver.FindElement(By.Id("mat-input-4"));
                email.SendKeys(Constants.firstName + random.Next(100, 9999) + "@gmail.com");


                IWebElement genderDropdown = driver.FindElement(By.ClassName("mat-select-placeholder"));
                genderDropdown.Click();

                IWebElement genderSelect = driver.FindElement(By.XPath("(//mat-option[@id='mat-option-0'])[1]"));
                genderSelect.Click();

                IWebElement dob = driver.FindElement(By.Id("dob"));
                dob.SendKeys(Constants.dob);

                IWebElement nextButton = driver.FindElement(By.XPath("(//button[@type='submit'][normalize-space()='Next'])[1]"));
                nextButton.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement Address1 = driver.FindElement(By.Id("mat-input-6"));
                Address1.SendKeys(Constants.address1);

                IWebElement city = driver.FindElement(By.Id("mat-input-8"));
                city.SendKeys(Constants.city);


                IWebElement stateDropDown = driver.FindElement(By.ClassName("mat-select-placeholder"));
                stateDropDown.Click();

                IWebElement state = driver.FindElement(By.XPath("(//mat-option[@id='mat-option-30'])[1]"));


                state.Click();
                IWebElement pin = driver.FindElement(By.Id("mat-input-9"));
                pin.SendKeys(Constants.pin);

                IWebElement nextClick = driver.FindElement(By.XPath(" (//button[@type='submit'][normalize-space()='Next'])[2]"));
                nextClick.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement skipButton = driver.FindElement(By.XPath("(//button[@class='mat-stepper-next btn ms-3 patient-form-reset-btn position-absolute reset-btn'])[1]"));
                skipButton.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement insuranceName = driver.FindElement(By.Id("mat-input-13"));
                insuranceName.SendKeys(Constants.insuranceName);
                IWebElement policyNumber = driver.FindElement(By.Id("mat-input-14"));
                policyNumber.SendKeys(Constants.policyNumber + random.Next(100, 1000));
                IWebElement policyfirstName = driver.FindElement(By.Id("mat-input-15"));
                policyfirstName.SendKeys(Constants.firstName);
                IWebElement policylastName = driver.FindElement(By.Id("mat-input-16"));
                policylastName.SendKeys(Constants.lastName + random.Next(100, 1000));
                IWebElement groupNumber = driver.FindElement(By.Id("mat-input-17"));
                groupNumber.SendKeys(Constants.groupNumber + random.Next(100, 1000));
                IWebElement skipClick = driver.FindElement(By.XPath(" (//button[@class='btn ms-3 patient-form-reset-btn position-absolute reset-btn'])[1]"));
                skipClick.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement skip2Click = driver.FindElement(By.XPath("(//button[@class='mat-stepper-next btn ms-3 reset-btn'])[1]"));
                skip2Click.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
               
                IWebElement monitoring = driver.FindElement(By.XPath("//body/div[2]/div[2]/div/mat-dialog-container/app-addpatient/mat-dialog-content/div[3]/div/mat-stepper/div[2]/div[5]/div/form/div[2]/div[1]/div/mat-form-field/div/div[1]/div"));
                monitoring.Click();
                
                IWebElement select = driver.FindElement(By.XPath(" //span[@class='mat-option-text'][normalize-space()='Hypertension']"));
                select.Click();
               IWebElement patientEMRId = driver.FindElement(By.Id("mat-input-23"));
                patientEMRId.SendKeys("1" + random.Next(100, 1000));

                IWebElement submit = driver.FindElement(By.XPath("(//button[normalize-space()='Submit'])[1]"));
                submit.Click();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IWebElement close = driver.FindElement(By.XPath("//button[normalize-space()='Close']"));
                close.Click();
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


            return underPracticeResponse;

        }
    }
}

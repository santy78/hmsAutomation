using HMS_Automation.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class Login_Page
    {
        public static int SessionId;
        public const string PagePath = "/login";
        public  void login(string username,string password, IWebDriver driver)
        {
            {
                SessionId = HMSAutomationDBContext.GetBatchID();

                // Create a new instance of the ChromeDriver


                // Navigate to a webpage
                driver.Navigate().GoToUrl("https://portal-dev.hmsrpm.com/HMS.DevUI/#/login");

                IWebElement usernameField = driver.FindElement(By.Id("phoneoremail"));
               // usernameField.SendKeys("associatemanager@hmsdemo.com");
                usernameField.SendKeys(username);

                IWebElement passwordField = driver.FindElement(By.Id("password"));
               // passwordField.SendKeys("Default@123");
                passwordField.SendKeys(password);

                IWebElement loginButton = driver.FindElement(By.CssSelector("button[type='submit']"));

                // Perform actions on the loginButton element
               
                loginButton.Click();

               
               

                Practice practice =new Practice();
                practice.ChoosePractice(driver);

                UnderPractice addPatient = new UnderPractice();
                 addPatient.Practice(driver);

                CreateOrder createOrder = new CreateOrder();
                createOrder.Order(driver);

                TrainingTracker trainingTracker = new TrainingTracker();
                trainingTracker.Training(driver);

                MyPatients myPatients = new MyPatients();
                myPatients.Patients(driver);

              TrainingReport trainingReport = new TrainingReport();
              trainingReport.ReportOfTraining(driver);

              
                BillingReport billingReport = new BillingReport();
                billingReport.ReportOfBilling(driver, SessionId);

                ServiceTimeReport serviceTimeReport = new ServiceTimeReport();
                serviceTimeReport.ReportOfServiceTime(driver);

                MissedUploadReport missedUploadReport = new MissedUploadReport();
                missedUploadReport.ReportOfMissedUpload(driver);

                UnreachableReport unreachableReport = new UnreachableReport();
                unreachableReport.ReportOfUnreachable(driver);

                MonthlyPatientReport monthlyPatientReport = new MonthlyPatientReport();
                monthlyPatientReport.ReportOfMonthlyPatient(driver);



            }
        }
    }
}


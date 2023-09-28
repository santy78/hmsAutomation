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
                HMSAutomationResult automationresult = new HMSAutomationResult();
                HMSAutomationDBContext automationDBContext = new HMSAutomationDBContext();
                automationresult.BatchId = SessionId;
                automationresult.ScreenName = "LOGIN";
                automationresult.ResponseType = "";
                automationresult.Request = "";
                automationresult.Response = "";
                automationresult.Errors = "";
                automationresult.DateTime = DateTime.Now.ToString();
                Random random = new Random();
                string RegisterLastName=Constants.lastName + random.Next(100, 1000);

                try
                {
                    // Navigate to a webpage
                    driver.Navigate().GoToUrl("https://portal-dev.hmsrpm.com/HMS.DevUI/#/login");

                    IWebElement usernameField = driver.FindElement(By.Id("phoneoremail"));
                    // usernameField.Sendeys("associatemanager@hmsdemo.com");
                    usernameField.SendKeys(username);

                    IWebElement passwordField = driver.FindElement(By.Id("password"));
                    // passwordField.SendKeys("Default@123");
                    passwordField.SendKeys(password);

                    IWebElement loginButton = driver.FindElement(By.CssSelector("button[type='submit']"));

                    // Perform actions on the loginButton element
                    loginButton.Click();

                    // Add a small wait (e.g., 2 seconds) after clicking the login button
                    // Add a wait using Thread.Sleep (e.g., 2 seconds)
                    Thread.Sleep(TimeSpan.FromSeconds(5));

                    automationresult.ResponseType = "PASS";


                    Practice practice = new Practice();
                    practice.ChoosePractice(driver, SessionId);

                    UnderPractice addPatient = new UnderPractice();
                    addPatient.Practice(driver, SessionId, RegisterLastName);
                    Onboarding patientonboarding = new Onboarding();
                    patientonboarding.PatientOnboarding(driver, SessionId, RegisterLastName);

                    CreateOrder createOrder = new CreateOrder();
                    createOrder.Order(driver, SessionId);

                    TrainingTracker trainingTracker = new TrainingTracker();
                    trainingTracker.Training(driver,SessionId);

                    MyPatients myPatients = new MyPatients();
                    myPatients.Patients(driver, SessionId);

                    TrainingReport trainingReport = new TrainingReport();
                    trainingReport.ReportOfTraining(driver, SessionId);


                    BillingReport billingReport = new BillingReport();
                    billingReport.ReportOfBilling(driver, SessionId);

                    ServiceTimeReport serviceTimeReport = new ServiceTimeReport();
                    serviceTimeReport.ReportOfServiceTime(driver, SessionId);

                    MissedUploadReport missedUploadReport = new MissedUploadReport();
                    missedUploadReport.ReportOfMissedUpload(driver, SessionId);

                    UnreachableReport unreachableReport = new UnreachableReport();
                    unreachableReport.ReportOfUnreachable(driver, SessionId);

                    MonthlyPatientReport monthlyPatientReport = new MonthlyPatientReport();
                    monthlyPatientReport.ReportOfMonthlyPatient(driver, SessionId);
                     Logout logout = new Logout();
                logout.logout_click(driver, SessionId);


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
}


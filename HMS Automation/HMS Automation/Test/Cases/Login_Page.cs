using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class Login_Page
    {
        public const string PagePath = "/login";
        public  void login(string username,string password, IWebDriver driver)
        {
            {
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

                Practice practice=new Practice();
                practice.ChoosePractice(driver);

                UnderPractice addPatient = new UnderPractice();
                addPatient.Practice(driver);


            }
        }
    }
}


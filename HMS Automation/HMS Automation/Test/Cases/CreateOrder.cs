﻿using Microsoft.VisualBasic;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    internal class CreateOrder
    {
        public void Order(IWebDriver driver)
        {
            //createorder screen

            IWebElement order = driver.FindElement(By.XPath("(//a[normalize-space()='CREATE ORDER'])[1]"));
            order.Click();

            //action
           
            IWebElement action = driver.FindElement(By.XPath("//mat-icon[normalize-space()='more_horiz']"));
            action.Click();

            IWebElement createOrder = driver.FindElement(By.XPath("(//button[normalize-space()='Create Order'])[1]"));
            createOrder.Click();

            //device

            IWebElement device = driver.FindElement(By.ClassName("mat-select-placeholder"));
            device.Click();

            IWebElement selectDevice = driver.FindElement(By.XPath("(//span[normalize-space()='Blood Pressure Cuff'])[1]"));
            selectDevice.Click();

            //deviceType
           
            IWebElement deviceType = driver.FindElement(By.ClassName("mat-select-placeholder"));
            deviceType.Click();

            IWebElement selectDeviceType = driver.FindElement(By.XPath("(//span[@class='mat-option-text'])[1]"));
            selectDeviceType.Click();

            //submit order

            IWebElement orderSubmit = driver.FindElement(By.XPath("(//button[@class='mat-focus-indicator accept-btn px-5 confirmation-text rounded-0 mat-button mat-button-base ng-star-inserted'])[1]"));
            orderSubmit.Click();

            //successfull

            IWebElement orderSuccessfull = driver.FindElement(By.XPath("(//mat-icon[normalize-space()='cancel'])[1]"));
            orderSuccessfull.Click();
           
        }

       
    }
}
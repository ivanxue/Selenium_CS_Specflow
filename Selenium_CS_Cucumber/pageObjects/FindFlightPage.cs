using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_CS_Cucumber.pageObjects
{
    public class FindFlightPage
    {
        private IWebDriver driver;

        public IWebElement tripTypeRadio => driver.FindElement(By.Name("tripType"));

        public IWebElement fromDropdown => driver.FindElement(By.Name("fromPort"));

        public IWebElement toDropdown => driver.FindElement(By.Name("toPort"));

        public IWebElement servClassRadio => driver.FindElement(By.Name("servClass"));

        public IWebElement continueFindBtn => driver.FindElement(By.Name("findFlights"));

        public FindFlightPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        public void FindFlight(string departFrom, string arriveIn)
        {
            Utils.Utils.CheckByValue("tripType", "oneway");
            Utils.Utils.SelectByValue("fromPort", departFrom);
            Utils.Utils.SelectByValue("toPort", arriveIn);
            Utils.Utils.CheckByValue("servClass", "First");

            continueFindBtn.Click();

        }
    }
}

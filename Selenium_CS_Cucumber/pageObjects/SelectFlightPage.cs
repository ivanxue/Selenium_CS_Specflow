using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_CS_Cucumber.pageObjects
{
    public class SelectFlightPage
    {
        IWebDriver driver;

        public IWebElement reserveBtn => driver.FindElement(By.Name("reserveFlights"));

        public SelectFlightPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void reserveFlight()
        {
            reserveBtn.Click();
        }
    }
}

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_CS_Cucumber.pageObjects
{
    public class FindFlightPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "tripType")]
        public IWebElement tripTypeRadio { get; set; }

        [FindsBy(How = How.Name, Using = "fromPort")]
        public IWebElement fromDropdown { get; set; }

        [FindsBy(How = How.Name, Using = "toPort")]
        public IWebElement toDropdown { get; set; }

        [FindsBy(How = How.Name, Using = "servClass")]
        public IWebElement servClassRadio { get; set; }

        [FindsBy(How = How.Name, Using = "findFlights")]
        public IWebElement continueFindBtn { get; set; }

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

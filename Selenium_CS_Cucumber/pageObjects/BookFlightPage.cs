using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_CS_Cucumber.pageObjects
{
    public class BookFlightPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "passFirst0")]
        public IWebElement firstNameInput { get; set; }

        [FindsBy(How = How.Name, Using = "passLast0")]
        public IWebElement lastNameInput { get; set; }

        [FindsBy(How = How.Name, Using = "creditnumber")]
        public IWebElement creditNumberInput { get; set; }

        [FindsBy(How = How.Name, Using = "ticketLess")]
        public IWebElement ticketlessTravelCheck { get; set; }

        [FindsBy(How = How.Name, Using = "buyFlights")]
        public IWebElement securePurchaseBtn { get; set; }

        public BookFlightPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void BookFlight(string firstName, string lastName, string creditNumber)
        {
            firstNameInput.SendKeys(firstName);
            lastNameInput.SendKeys(lastName);
            creditNumberInput.SendKeys(creditNumber);

            ticketlessTravelCheck.Click();
            securePurchaseBtn.Click();
        }
    }
}

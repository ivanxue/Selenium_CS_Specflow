using OpenQA.Selenium;

namespace Selenium_CS_POM.pageObjects
{
    public class BookFlightPage
    {
        private IWebDriver driver;

        public IWebElement firstNameInput => driver.FindElement(By.Name("passFirst0"));

        public IWebElement lastNameInput => driver.FindElement(By.Name("passLast0"));

        public IWebElement creditNumberInput => driver.FindElement(By.Name("creditnumber"));

        public IWebElement ticketlessTravelCheck => driver.FindElement(By.Name("ticketLess"));

        public IWebElement securePurchaseBtn => driver.FindElement(By.Name("buyFlights"));

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

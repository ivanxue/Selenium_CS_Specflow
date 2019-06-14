using OpenQA.Selenium;

namespace Selenium_CS_POM.pageObjects
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

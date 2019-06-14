using OpenQA.Selenium;

namespace Selenium_CS_POM.pageObjects
{
    public class ConfirmationPage
    {
        private IWebDriver driver;

        public IWebElement backToHomeBtn => driver.FindElement(By.XPath("//*/tbody/tr[7]/td/table/tbody/tr/td[2]/a"));

        public IWebElement logoutBtn => driver.FindElement(By.XPath("//*/tbody/tr[7]/td/table/tbody/tr/td[3]/a"));

        public ConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ReviewFlight()
        {
            backToHomeBtn.Click();

        }
    }
}

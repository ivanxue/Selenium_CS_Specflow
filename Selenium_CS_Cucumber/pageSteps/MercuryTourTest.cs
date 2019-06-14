using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium_CS_Cucumber.pageObjects;
using TechTalk.SpecFlow;

namespace Selenium_CS_POM.pageSteps
{
    [Binding]
    public class MercuryTourTest
    {
        public static IWebDriver driver;
        public LoginPage loginPage;
        public FindFlightPage findFlightsPage;

        [Given("^url opened with browser ([^\"]*)$")]
    public void url_opened(string browser)
        {
            driver = Utils.Utils.OpenBrowser("http://newtours.demoaut.com/mercurypurchase.php", browser);
            loginPage = new LoginPage(driver);
            findFlightsPage = new FindFlightPage(driver);
        }

        [When("^enter user id as ([^\"]*)$")]
    public void enterUserIdAsUserName(string userName)
        {
            loginPage.userNameInput.SendKeys(userName);
        }

        [When("^enter password as ([^\"]*)$")]
    public void enterPasswordAsPassword(String password)
        {
            loginPage.passwordInput.SendKeys(password);
            }

        [When("^click login$")]
    public void click_login()
        {
            loginPage.loginBtn.Click();
        }

        [Then("^select flight form exists$")]
    public void selectFlightFormExists()
        {
            Assert.AreEqual(findFlightsPage.fromDropdown.Displayed, true);
        }
    }
}

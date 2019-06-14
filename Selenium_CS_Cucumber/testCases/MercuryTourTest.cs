using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium_CS_Cucumber.pageObjects;

namespace Selenium_CS_Cucumber.testCases
{
    public class MercuryTourTest
    {
        public IWebDriver driver;
        public LoginPage loginPage;
        public FindFlightPage findFlightPage;
        public SelectFlightPage selectFlightPage;
        public BookFlightPage bookFlightPage;
        public ConfirmationPage confirmationPage;

        [SetUp]
        public void LaunchBrowser()
        {
            driver = Utils.Utils.OpenBrowser("http://newtours.demoaut.com/mercurypurchase.php", "chrome");
            loginPage = new LoginPage(driver);
            findFlightPage = new FindFlightPage(driver);
            selectFlightPage = new SelectFlightPage(driver);
            bookFlightPage = new BookFlightPage(driver);
            confirmationPage = new ConfirmationPage(driver);
        }

        [Test]
        public void login()
        {
            Utils.Utils.WaitForElement(loginPage.userNameInput);
            Utils.Utils.ValidatePageTitle("Welcome: Mercury Tours");

            loginPage.login("mercury", "mercury");

        }

    
    }
}

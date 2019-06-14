using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium_CS_POM.pageObjects;

namespace Selenium_CS_POM.testCases
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

        [TestCase("Sydney", "London")]
        [TestCase("London", "Sydney")]
        public void MecurityTest(string from, string to)
        {
            Utils.Utils.WaitForElement(loginPage.userNameInput);
            Utils.Utils.ValidatePageTitle("Welcome: Mercury Tours");

            loginPage.login("mercury", "mercury");

            Utils.Utils.WaitForElement(findFlightPage.tripTypeRadio);
            Utils.Utils.ValidatePageTitle("Find a Flight: Mercury Tours:");

            findFlightPage.FindFlight(from, to);

            Utils.Utils.WaitForElement(selectFlightPage.reserveBtn);
            Utils.Utils.ValidatePageTitle("Select a Flight: Mercury Tours");

            selectFlightPage.reserveFlight();

            Utils.Utils.WaitForElement(bookFlightPage.firstNameInput);
            Utils.Utils.ValidatePageTitle("Book a Flight: Mercury Tours");

            bookFlightPage.BookFlight("Ivan", "Xue", "12345678");

            Utils.Utils.WaitForElement(confirmationPage.backToHomeBtn);
            Utils.Utils.ValidatePageTitle("Flight Confirmation: Mercury Tours");

            confirmationPage.ReviewFlight();

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}

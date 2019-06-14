using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Selenium_CS_Cucumber.Utils
{
    public class Utils
    {
        public static IWebDriver driver = null;

        public static IWebDriver OpenBrowser(string URL, string browserName)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            switch (browserName)
            {
                case "chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("no-sandbox");
                    driver = new ChromeDriver(@"../../drivers/chromedriver");
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "safari":
                    driver = new SafariDriver();
                    break;
                default:
                    Console.WriteLine(browserName + " is not valid, launching Firefox by default");
                    driver = new FirefoxDriver();
                    break;
            }
                
                driver.Url = URL;
            return driver;
        }

        public static void ValidatePageTitle(string expectedPageTitle)
        {
            string pageTitle = driver.Title;
            Console.WriteLine("Actual page title is " + pageTitle);
            Console.WriteLine("Expected page title is " + expectedPageTitle);
            Assert.AreEqual(pageTitle, expectedPageTitle);

        }

        public static void WaitForElement(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public static void CheckByValue(string name, string expectedValue)
        {
            var selectOptions = driver.FindElements(By.Name(name));
            int size = selectOptions.Count;
            for(int i = 0; i < size; i++)
            {
                string actualValue = selectOptions[i].GetAttribute("value");
                if(actualValue.Equals(expectedValue))
                {
                    selectOptions[i].Click();
                    break;
                }
            }

        }

        public static void SelectByValue(string name, string expectedValue)
        {
            IWebElement selectDropdown = driver.FindElement(By.Name(name));
            var selectElement = new SelectElement(selectDropdown);
            selectElement.SelectByValue(expectedValue);

        }
    }
}

using System;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OfferPadTest
{
    public class Validators
    {
        public Validators()
        {
        }

        Utilities utilities = new Utilities();
        Events events = new Events();

        public void assertErrorByID(IWebDriver driver, String id)
        {
            utilities.logComment("Checking for display of " + id);
            Assert.IsTrue(driver.FindElement(By.Id(id)).Displayed);
        }

        public void zipCodeValidation(IWebDriver driver, String text)
        {
            events.enterTextByID(driver, "ZipCode", text);
            driver.FindElement(By.Id("ZipCode")).SendKeys(Keys.Tab);
            assertErrorByID(driver, "ZipCode-error");
        }

    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OfferPadTest
{
    [TestClass]
    public class TestHomePage
    {
        public TestHomePage()
        {
        }

        Validators validators = new Validators();
        Events events = new Events();
        Environment environment = new Environment();
        Utilities utilities = new Utilities();

        [TestMethod]
        public void TestHomePageHasAddressInput()
        {
            using (var driver = new ChromeDriver(environment.ChromeDriverFolder))
            {
                utilities.launchApp(driver, environment.URL);

                var addressInput = driver.FindElementsById("address-input").FirstOrDefault();

                Assert.IsNotNull(addressInput);
                driver.Quit();
            }
        }

        [TestMethod]
        public void TestHomePageDoesNotHaveError()
        {
            using (var driver = new ChromeDriver(environment.ChromeDriverFolder))
            {
                utilities.launchApp(driver, environment.URL);

                var error = driver.FindElementsByClassName("error").FirstOrDefault();

                Assert.IsNull(error);
                driver.Quit();
            }
        }

        [TestMethod]
        public void TestHomePageRequestOffer()
        {
            using (var driver = new ChromeDriver(environment.ChromeDriverFolder))
            {
                utilities.launchApp(driver, environment.URL);

                events.enterTextByID(driver, "address-input", "ABCD");
                events.clickButtonByClass(driver, "submit");
                string activeStep = driver.FindElementByClassName("active").FindElement(By.ClassName("badge-header")).GetAttribute("innerHTML");

                Assert.AreEqual(activeStep, "Step 1");

                driver.Quit();

            }
        }

        [TestMethod]
        public void TestContactInfoReqFields()
        {
            using (var driver = new ChromeDriver(environment.ChromeDriverFolder))
            {
                utilities.launchApp(driver, environment.URL);

                events.enterTextByID(driver, "address-input", "ABCD");
                events.clickButtonByClass(driver, "submit");
                driver.FindElementById("next").Click();

                Assert.IsTrue(driver.FindElement(By.ClassName("validation-summary-errors")).Displayed);
                validators.assertErrorByID(driver, "StreetAddress-error");
                validators.assertErrorByID(driver, "City-error");
                validators.assertErrorByID(driver, "State-error");
                validators.assertErrorByID(driver, "ZipCode-error");
                validators.assertErrorByID(driver, "OwnerRequest-error");

                driver.Quit();

            }
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace OfferPadTest
{
    [TestClass]
    public class TestOfferPage
    {
        public TestOfferPage()
        {
        }

        Validators validators = new Validators();
        Events events = new Events();
        Environment environment = new Environment();
        Utilities utilities = new Utilities();

        [TestMethod]
        public void TestBoundryOfferPageZip()
        {
            using (var driver = new ChromeDriver(environment.ChromeDriverFolder))
            {

                utilities.launchApp(driver, environment.URL);

                events.enterTextByID(driver, "address-input", "ABCD");
                events.clickButtonByClass(driver, "submit");
                driver.FindElementById("next").Click();

                //The below fields have no error checking, can accept chars, symbols
                events.enterTextByID(driver, "StreetAddress", "1 Main St");
                events.enterTextByID(driver, "City", "1 Main St");
                events.enterTextByID(driver, "State", "1 Main St");
                events.selectListByIdAndText(driver, "State", "California");

                //Zip has error checking
                //Receives error with symbols
                validators.zipCodeValidation(driver, "((");

                //receives error with alpha
                validators.zipCodeValidation(driver, "AAAaa-aaaa");

                //receives error with too many numbers
                validators.zipCodeValidation(driver, "22222222222222");

                //receives error with alpha & symbols
                validators.zipCodeValidation(driver, "85211-abcd");

                //receives error with leading spaces
                validators.zipCodeValidation(driver, "   85255-3333");

                //receives error with trailing spaces
                validators.zipCodeValidation(driver, "85255-2222  ");

                //receives error with spaces in middle
                validators.zipCodeValidation(driver, "85266     9222  ");

                driver.Quit();

            }
        }
    }
}

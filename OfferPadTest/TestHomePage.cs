using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace OfferPadTest
{
    [TestClass]
    public class TestHomePage
    {
        public static string HomePageURL = System.Configuration.ConfigurationManager.AppSettings["HomePageURL"].ToString();

        [TestMethod]
        public void TestHomePageHasAddressInput()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomePageURL);

                var addressInput = driver.FindElementsById("address-input").FirstOrDefault();

                Assert.IsNotNull(addressInput);
            }
        }

        [TestMethod]
        public void TestHomePageDoesNotHaveError()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomePageURL);

                var error = driver.FindElementsByClassName("error").FirstOrDefault();

                Assert.IsNull(error);
            }
        }
    }
}

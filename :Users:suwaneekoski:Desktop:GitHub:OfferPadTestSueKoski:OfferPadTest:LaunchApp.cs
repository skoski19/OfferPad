using System;
using OpenQA.Selenium.Chrome;

namespace OfferPadTest
{
    public class LaunchApp
    {
        public LaunchApp()
        {
        }
        Environment environment = new Environment();

        public void launchApp(){
            using (var driver = new ChromeDriver(environment.ChromeDriverFolder))
            {
                driver.Navigate().GoToUrl(environment.HomePageURL);

            }
    }
}

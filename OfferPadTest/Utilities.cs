using System;
using System.Diagnostics;
using OpenQA.Selenium;

namespace OfferPadTest
{
    public class Utilities
    {
        public Utilities()
        {
            
        }

        Environment environment = new Environment();


        public void logComment(String text)
        {
            Trace.WriteLine(text);
        }

        public void launchApp(IWebDriver driver, String url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }

}

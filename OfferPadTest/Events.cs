using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace OfferPadTest
{
    public class Events
    {
        public Events()
        {
        }

        Utilities utilities = new Utilities();

        public void clickLinkByID(IWebDriver driver, String id)
        {
            driver.FindElement(By.Id(id)).Click();
            utilities.logComment("Clicked " + id + " link");
        }

        public void clickButtonByClass(IWebDriver driver, String className)
        {
            driver.FindElement(By.ClassName(className)).Click();
            utilities.logComment("Clicked " + className + " button");
        }

        public void enterTextByID(IWebDriver driver, String id, String text)
        {
            driver.FindElement(By.Id(id)).Click();

            //Clear the data from uneditable field
            driver.FindElement(By.Id(id)).SendKeys(Keys.End+ Keys.Shift + Keys.Home+ Keys.Delete);
            driver.FindElement(By.Id(id)).SendKeys(text);
            utilities.logComment("Entered " + text + " in " + id);
        }


        public void selectListByIdAndText(IWebDriver driver, String id, String text)
        {
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Id(id)));

            dropDown.SelectByText(text);

            utilities.logComment("Selected from list " + id + " item: " + text);
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace SeleniumTest
{
    public class CategoriesPage
    {
        private IWebDriver driver;
        private WebDriverWait webDriverWait;
        private By categoryHeaderLocator = By.CssSelector("ul.sf-menu > li > a[title='Dresses']");
        private By productCounterLocator = By.CssSelector(".heading-counter");


        public void GoToPage()
        {
          string url = ConfigurationManager.AppSettings["url"];
            driver.Navigate().GoToUrl($"{url}/index.php");
        }

        public CategoriesPage(IWebDriver driver)
        {
            this.driver = driver;
            webDriverWait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
        }

        public void ClickHeaderButton()
        {
            driver.FindElement(categoryHeaderLocator).Click();
        }

        public string ProductCounter()
        {
            var count = driver.FindElement(productCounterLocator);
            string counter = count.Text;
            return counter;
        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    public class ContactUsPage
    {
        private IWebDriver driver;

        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }
    }
}

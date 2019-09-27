using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    [TestFixture]

    class ContactUsTest : TestBase
    {

        [SetUp]
        // najpierw wykona setup w klasie bazowej i dopiero w naszej klasie
        //czyli tu możemy wpisać inny url do wszystkich testów poniżej

        // driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

        [Test]
        public void ContactError()
        {

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            var contactHeader = driver.FindElement(By.CssSelector("#contact-link"));  //ten element musimy do czegoś przypisać
            contactHeader.Click();

            driver.FindElement(By.CssSelector("#submitMessage")).Click();

            WebDriverWait waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
            waitDriver.Until(ExpectedConditions.ElementExists(By.CssSelector(".alert-danger")));  //będzie czekać 15 sekund aż nie znajdzie tego elementu, to samo co implicit ale lokalnie plus możemy czekać aż np się nie pojawi - bardziej rozbudowany

            var ifError = driver.FindElement(By.CssSelector(".alert-danger"));  //można dodać li jeśli chcemy się dostać do elementu w środku czyli invalid email adres
            string text = ifError.Text;
            
            StringAssert.Contains("error", text);

            Assert.IsTrue(ifError.Displayed, "Error message wasn't displayed to user");

            
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTest.Pages;
using System.IO;

namespace SeleniumTest
{
    [TestFixture]

    class ContactUsTest : TestBase
    {
        ContactUsPage sut;  //system under test

        [SetUp]
        // najpierw wykona setup w klasie bazowej i dopiero w naszej klasie
        //czyli tu możemy wpisać inny url do wszystkich testów poniżej
        public void ContactUsSetup()
        {
            sut = new ContactUsPage(driver);
            sut.GoToPage();
        }

        [Test]
        public void ContactError()
        {

                    //  driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

                    //   var contactHeader = driver.FindElement(By.CssSelector("#contact-link"));  //ten element musimy do czegoś przypisać
                    //   contactHeader.Click();

                    // driver.FindElement(By.CssSelector("#submitMessage")).Click();
            sut.ClickSubmitButton();

                    //WebDriverWait waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
                    //waitDriver.Until(ExpectedConditions.ElementExists(By.CssSelector(".alert-danger")));  //będzie czekać 15 sekund aż nie znajdzie tego elementu, to samo co implicit ale lokalnie plus możemy czekać aż np się nie pojawi - bardziej rozbudowany

            var errorMessage = sut.GetErrorMessage();

                    //var ifError = driver.FindElement(By.CssSelector(".alert-danger"));  //można dodać li jeśli chcemy się dostać do elementu w środku czyli invalid email adres
                    //string text = ifError.Text;
            
            StringAssert.Contains("error", errorMessage);

                // Assert.IsTrue(ifError.Displayed, "Error message wasn't displayed to user");

            
        }

        // zapisywanie rzeczy do pliku
        [Test]
        public void StreamWriterExample()
        {



            using(StreamReader sr = new StreamReader)
            using (StreamWriter sw = new StreamWriter(@"C:\workspace\git\workshop_gdansk") ;
            for (int i = 0; i < 100; i++) {
                sw = 


                    // brać linijka po linijce i zmieniać wartości tej którą chcemy
            }
            
        }



    }
}

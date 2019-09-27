using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SeleniumTest
{
    [TestFixture]
    public class Class1
    {
        IWebDriver driver;  //teraz ten driver będzie widoczny dla innych metod w teście, tu już deklarujemy ją i dlatego na dole już kasujemy var driver tylko przypisujemy do driver

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();  // tworzy obiekt tego drivera, postaw server tego drivera, skoro we wszystkich testach będziemy używać tego driver to inicjalizujemy go poza testem
            var waitTime = new System.TimeSpan(0, 0, 1);
            driver.Manage().Timeouts().ImplicitWait=waitTime;
        }

        //[TestCase("ul.sf-menu > li > a[title='Dresses']")]


        //public void CheckingProductNumber(string element, string productCounter)
        //{
        //    var categoryHeader = driver.FindElement(By.CssSelector(element));
        //    categoryHeader.Click();

        //    var product = driver.FindElement(By.CssSelector(productCounter));
        //    string text = productCounter.Text;
        //    StringAssert.Contains("5", text);

        //}


        [Test]
        public void FirstTest()
        {

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='Dresses']"));  //ten element musimy do czegoś przypisać
            //element.jedna z klas > weź bezpośrednie dziecko
            categoryHeader.Click();
            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productCounter.Text;
            var webElements = driver.FindElements(By.CssSelector("div.product-container")); //mamy kolekcje i możemy z niego brać numery z danej kolekcji

            string actualElementCount = webElements.Count.ToString();


            // text.Contains("5");  albo lepiej funkcją która obsługuje stringi
            // StringAssert.Contains("5", text);
            StringAssert.Contains(actualElementCount, text);



        }

        [TearDown]   //to jest atrybut który odpowiada za sprzątanie
        public void TearDown()
        {
            driver.Quit();
        }
    }
}

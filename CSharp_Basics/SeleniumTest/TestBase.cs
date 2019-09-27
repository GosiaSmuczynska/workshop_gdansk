using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class TestBase
    {
        protected IWebDriver driver;  //teraz ten driver będzie widoczny dla innych metod w teście, tu już deklarujemy ją i dlatego na dole już kasujemy var driver tylko przypisujemy do driver
        // jeste też protected: i ta klasa która dziedziczy jest dla niej ok, tylko dzieci mogą się do niej dostać
        //public widza wszyscy

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();  // tworzy obiekt tego drivera, postaw server tego drivera, skoro we wszystkich testach będziemy używać tego driver to inicjalizujemy go poza testem
            var waitTime = new System.TimeSpan(0, 0, 8);
            driver.Manage().Timeouts().ImplicitWait = waitTime;
        }

        [TearDown]   //to jest atrybut który odpowiada za sprzątanie
        public void TearDown()
        {
            driver.Quit();
        }

    }
}

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
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();  // tworzy obiekt tego drivera, postaw server tego drivera, skoro we wszystkich testach będziemy używać tego driver to inicjalizujemy go poza testem
            var waitTime = new System.TimeSpan(0, 0, 1);
            driver.Manage().Timeouts().ImplicitWait = waitTime;
        }

        [TearDown]   //to jest atrybut który odpowiada za sprzątanie
        public void TearDown()
        {
            driver.Quit();
        }

    }
}

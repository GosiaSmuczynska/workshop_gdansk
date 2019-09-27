using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;


namespace SeleniumTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void FirstTest()
        {
            new ChromeDriver();
        }
    }
}

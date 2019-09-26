using NUnit.Framework;
using System;
using Calk2;


namespace Calc2Test
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1, 4, 5)]
        [TestCase(1, -1, 0)]
        [TestCase(int.MaxValue, int.MaxValue, 5)]
        [TestCase(-1, -4, -5)]

        public void AddingOperation_PossitiveValues(int firstValue, int secondValue, int expectectedReslut)
        {
            // Arrage
            MathData mathData = new MathData(firstValue, secondValue, "+");

            // Act - wykonujmey operację
            var result = Calculations.Oblicz(mathData);

            //Assert - robimy asercję do tej operacji
            Assert.AreEqual(expectectedReslut, result);
        }
        
        //[Test]
        //public void AddingOperation_PossitiveAndNegativeValues()
        //{
        //    // Arrage
        //    MathData mathData = new MathData(-1, 1, "+");

        //    // Act - wykonujmey operację
        //    var result = Calculations.Oblicz(mathData);

        //    //Assert - robimy asercję do tej operacji
        //    Assert.AreEqual(0, result);
        //}

        //[Test]
        //public void AddingOperation_NegativeValues()
        //{
        //    // Arrage
        //    MathData mathData = new MathData(-5, -3, "+");

        //    // Act - wykonujmey operację
        //    var result = Calculations.Oblicz(mathData);

        //    //Assert - robimy asercję do tej operacji
        //    Assert.AreEqual(-8, result);
        //}

        //[Test]
        //public void AddingOperation_MaxValues()
        //{
        //    // Arrage
        //    MathData mathData = new MathData(int.MaxValue, int.MaxValue, "+");

        //    // Act - wykonujmey operację
        //    var result = Calculations.Oblicz(mathData);

        //    //Assert - robimy asercję do tej operacji
        //    Assert.AreEqual(0, result);
        //}
        
        //[Test]
        //public void AddingOperation_BigValues()
        //{
        //    // Arrage
        //    MathData mathData = new MathData(30000, 31000, "+");

        //    // Act - wykonujmey operację
        //    var result = Calculations.Oblicz(mathData);

        //    //Assert - robimy asercję do tej operacji
        //    Assert.AreEqual(61000, result);
        //}


    }
}

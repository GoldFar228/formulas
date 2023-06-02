using formulas;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var productPrice = 5000;
            var desiredProfit = 800000;
            var delta = 0.005;
            Assert.AreEqual(160.0, Formulas.DesiredProfitPercantage(desiredProfit,productPrice), delta);
        }

        [Test]
        public void Test2()
        {
            var productPrice = -5000;
            var desiredProfit = 800000;
            Assert.Throws<ArgumentException>(() => Formulas.DesiredProfitPercantage(desiredProfit, productPrice), "productPrice has to be positive");
        }
        //----------------------SellVolume-----------------------------
        [Test]
        public void Test3()
        {
            var fixedCosts = -50000;
            var desiredProfit = 400000;
            var productPrice = 5000;
            var variableCosts = 1000;
            Assert.Throws<ArgumentException>(() => Formulas.SellVolume(fixedCosts, desiredProfit, productPrice, variableCosts), "fixedCosts has to be positive");
        }
        [Test]
        public void Test4()
        {
            var fixedCosts = 80000;
            var desiredProfit = 800000;
            var productPrice = 5000;
            var variableCosts = 1500;
            var delta = 0.005;
            Assert.AreEqual(251.429, Formulas.SellVolume(fixedCosts, desiredProfit, productPrice, variableCosts), delta);
        }

        [Test]
        public void Test5()
        {
            var fixedCosts = 50000;
            var desiredProfit = -400000;
            var productPrice = 5000;
            var variableCosts = 1000;
            Assert.Throws<ArgumentException>(() => Formulas.SellVolume(fixedCosts, desiredProfit, productPrice, variableCosts), "desiredProfit has to be positive");
        }

        [Test]
        public void Test6()
        {
            var fixedCosts = 50000;
            var desiredProfit = 400000;
            var productPrice = -5000;
            var variableCosts = 1000;
            Assert.Throws<ArgumentException>(() => Formulas.SellVolume(fixedCosts, desiredProfit, productPrice, variableCosts), "productPrice has to be positive"); 
        }

        [Test]
        public void Test7()
        {
            var fixedCosts = 50000;
            var desiredProfit = 400000;
            var productPrice = 5000;
            var variableCosts = -1000;
            Assert.Throws<ArgumentException>(() => Formulas.SellVolume(fixedCosts, desiredProfit, productPrice, variableCosts), "variableCosts has to be positive");
        }
        //----------------------SellVolume-----------------------------
        //----------------------SellSummary----------------------------
        [Test]
        public void Test8()
        {
            var productPrice = -5000;
            var sellVolume = 176;
            Assert.Throws<ArgumentException>(() => Formulas.SellSummary(productPrice, sellVolume), "productPrice has to be positive");
        }

        [Test]
        public void Test9()
        {
            var productPrice = 5000;
            var sellVolume = -176;
            Assert.Throws<ArgumentException>(() => Formulas.SellSummary(productPrice, sellVolume), "sellVolume has to be positive");
        }

        [Test]
        public void Test10()
        {
            var productPrice = 5000;
            var sellVolume = 176;
            var delta = 0.005;
            Assert.AreEqual(880000.0, Formulas.SellSummary(productPrice, sellVolume), delta); 
        }
        //----------------------SellSummary----------------------------
        //----------------------Profit---------------------------------
        [Test]
        public void Test11()
        {
            var productPrice = -5000;
            var variableCosts = 1500;
            var sellVolume = 176;
            var fixedCosts = 80000;
            Assert.Throws<ArgumentException>(() => Formulas.Profit(productPrice, variableCosts ,sellVolume, fixedCosts), "productPrice has to be positive");
        }

        [Test]
        public void Test12()
        {
            var productPrice = 5000;
            var variableCosts = 1500;
            var sellVolume = -176;
            var fixedCosts = 80000;
            Assert.Throws<ArgumentException>(() => Formulas.Profit(productPrice, variableCosts, sellVolume, fixedCosts), "sellVolume has to be positive");
        }
        [Test]
        public void Test13()
        {
            var productPrice = 5000;
            var variableCosts = -1500;
            var sellVolume = 176;
            var fixedCosts = 80000;
            Assert.Throws<ArgumentException>(() => Formulas.Profit(productPrice, variableCosts, sellVolume, fixedCosts), "variableCosts has to be positive");
        }

        [Test]
        public void Test14()
        {
            var productPrice = 5000;
            var variableCosts = 1500;
            var sellVolume = 176;
            var fixedCosts = -80000;
            Assert.Throws<ArgumentException>(() => Formulas.Profit(productPrice, variableCosts, sellVolume, fixedCosts), "fixedCosts has to be positive");
        }

        [Test]
        public void Test15()
        {
            var productPrice = 5000;
            var variableCosts = 1500;
            var sellVolume = 176;
            var fixedCosts = 80000;
            var delta = 0.005;
            Assert.AreEqual(536000.0, Formulas.Profit(productPrice, variableCosts, sellVolume, fixedCosts), delta);
        }
        //----------------------Profit---------------------------------
        //----------------------CostPrice------------------------------

        [Test]
        public void Test16()
        {
            var variableCosts = -1500;
            var fixedCosts = 80000;
            var volumeOfProduction = 1500;
            Assert.Throws<ArgumentException>(() => Formulas.CostPrice(variableCosts, fixedCosts, volumeOfProduction), "variableCosts has to be positive");
        }

        [Test]
        public void Test17()
        {
            var variableCosts = 1500;
            var fixedCosts = -80000;
            var volumeOfProduction = 1500;
            Assert.Throws<ArgumentException>(() => Formulas.CostPrice(variableCosts, fixedCosts, volumeOfProduction), "fixedCosts has to be positive");
        }
        [Test]
        public void Test18()
        {
            var variableCosts = 1500;
            var fixedCosts = 80000;
            var volumeOfProduction = -1500;
            Assert.Throws<ArgumentException>(() => Formulas.CostPrice(variableCosts, fixedCosts, volumeOfProduction), "volumeOfProduction has to be positive");
        }
        [Test]
        public void Test19()
        {
            var variableCosts = 1500;
            var fixedCosts = 80000;
            var volumeOfProduction = 1500;
            var delta = 0.005;
            Assert.AreEqual(1553.333, Formulas.CostPrice(variableCosts, fixedCosts, volumeOfProduction), delta);
        }
        //----------------------CostPrice------------------------------
        //----------------------ProductPrice---------------------------
        [Test]
        public void Test21()
        {
            var costPrice = -1553.333;
            var desiredProfitPercentage = 30;
            Assert.Throws<ArgumentException>(() => Formulas.ProductPrice(costPrice, desiredProfitPercentage), "costPrice has to be positive");
        }
        [Test]
        public void Test22()
        {
            var costPrice = 1553.333;
            var desiredProfitPercentage = -30;
            Assert.Throws<ArgumentException>(() => Formulas.ProductPrice(costPrice, desiredProfitPercentage), "desiredProfitPercentage has to be positive");
        }
        [Test]
        public void Test23()
        {
            var costPrice = 1553.333;
            var desiredProfitPercentage = 160;
            var delta = 0.005;
            Assert.AreEqual(4038.666, Formulas.ProductPrice(costPrice, desiredProfitPercentage), delta);
        }
        //----------------------ProductPrice---------------------------
        //----------------------QuantityPoint--------------------------
        [Test]
        public void Test24()
        {
            var fixedCosts = -80000;
            var productPrice = 5000;
            var variableCosts = 1500;
            Assert.Throws<ArgumentException>(() => Formulas.QuantityPoint(fixedCosts, productPrice, variableCosts), "fixedCosts has to be positive");
        }
        [Test]
        public void Test25()
        {
            var fixedCosts = 80000;
            var productPrice = -5000;
            var variableCosts = 1500;
            Assert.Throws<ArgumentException>(() => Formulas.QuantityPoint(fixedCosts, productPrice, variableCosts), "productPrice has to be positive");
        }
        [Test]
        public void Test26()
        {
            var fixedCosts = 80000;
            var productPrice = 5000;
            var variableCosts = -1500;
            Assert.Throws<ArgumentException>(() => Formulas.QuantityPoint(fixedCosts, productPrice, variableCosts), "variableCosts has to be positive");
        }
        [Test]
        public void Test27()
        {
            var fixedCosts = 80000;
            var productPrice = 5000;
            var variableCosts = 1500;
            var delta = 0.005;
            Assert.AreEqual(23, Formulas.QuantityPoint(fixedCosts, productPrice, variableCosts), delta);
        }
        //----------------------QuantityPoint--------------------------
        //----------------------MoneyPoint-----------------------------
        [Test]
        public void Test28()
        {
            var productPrice = -5000;
            var quantityPoint = 23;
            Assert.Throws<ArgumentException>(() => Formulas.MoneyPoint(productPrice, quantityPoint), "productPrice has to be positive");
        }
        [Test]
        public void Test29()
        {
            var productPrice = 5000;
            var quantityPoint = -23;
            Assert.Throws<ArgumentException>(() => Formulas.MoneyPoint(productPrice, quantityPoint), "quantityPoint has to be positive");
        }
        [Test]
        public void Test30()
        {
            var productPrice = 5000;
            var quantityPoint = 23;
            var delta = 0.005;
            Assert.AreEqual(115000, Formulas.MoneyPoint(productPrice, quantityPoint), delta);
        }
        //----------------------MoneyPoint-----------------------------
        //----------------------VariableCosts--------------------------
        [Test]
        public void Test31()
        {
            var productPrice = -5000;
            var variableCostsPercantage = 30;
            Assert.Throws<ArgumentException>(() => Formulas.VariableCosts(productPrice, variableCostsPercantage), "productPrice has to be positive");
        }
        [Test]
        public void Test32()
        {
            var productPrice = 5000;
            var variableCostsPercantage = -30;
            Assert.Throws<ArgumentException>(() => Formulas.VariableCosts(productPrice, variableCostsPercantage), "variableCostsPercantage has to be positive");
        }
        [Test]
        public void Test37()
        {
            var productPrice = 5000;
            var variableCostsPercantage = 130;
            Assert.Throws<ArgumentException>(() => Formulas.VariableCosts(productPrice, variableCostsPercantage), "variableCostsPercantage has to be less than 100");
        }
        [Test]
        public void Test33()
        {
            var productPrice = 5000;
            var variableCostsPercantage = 30;
            var delta = 0.005;
            Assert.AreEqual(1500, Formulas.VariableCosts(productPrice, variableCostsPercantage), delta);
        }
        //----------------------VariableCosts--------------------------

        //----------------------VariableCostsPercantage----------------
        [Test]
        public void Test34()
        {
            var productPrice = -5000;
            var variableCosts = 1500;
            Assert.Throws<ArgumentException>(() => Formulas.VariableCostsPercantage(productPrice, variableCosts), "productPrice has to be positive");
        }
        [Test]
        public void Test35()
        {
            var productPrice = 5000;
            var variableCosts = -1500;
            Assert.Throws<ArgumentException>(() => Formulas.VariableCostsPercantage(productPrice, variableCosts), "variableCosts has to be positive");
        }
        [Test]
        public void Test36()
        {
            var productPrice = 5000;
            var variableCosts = 1500;
            var delta = 0.005;
            Assert.AreEqual(30, Formulas.VariableCostsPercantage(productPrice, variableCosts), delta);
        }
        //----------------------VariableCostsPercantage----------------
    }

}
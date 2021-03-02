using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathHelper;
using System;

namespace MathHelperTest
{
    [TestClass]
    public class CombinatoricsTest
    {
        [TestMethod]
        public void FactorialTest()
        {
            Combinatorics comb = new Combinatorics(1, 1);
            Assert.AreEqual(1, comb.Factorial(0));
            Assert.AreEqual(1, comb.Factorial(1));
            Assert.AreEqual(2, comb.Factorial(2));
            Assert.AreEqual(6, comb.Factorial(3));
            Assert.AreEqual(24, comb.Factorial(4));
            Assert.AreEqual(120, comb.Factorial(5));
            Assert.AreEqual(720, comb.Factorial(6));
            Assert.AreEqual(5040, comb.Factorial(7));
        }
        [TestMethod]
        public void PTest()
        {
            Combinatorics comb = new Combinatorics(5);
            Assert.AreEqual(120, comb.P);

            comb = new Combinatorics(10);
            Assert.AreEqual(3628800, comb.P);

            comb = new Combinatorics(8);
            Assert.AreEqual(40320, comb.P);
        }
        Combinatorics comb1;
        Combinatorics comb2;
        Combinatorics comb3;
        [TestMethod]
        public void CTest()
        {
            InitialCombs();
            Assert.AreEqual(2, comb1.C);
            Assert.AreEqual(10, comb2.C);
            Assert.AreEqual(10, comb3.C);
        }
        [TestMethod]
        public void ATest()
        {
            InitialCombs();
            Assert.AreEqual(2, comb1.A);
            Assert.AreEqual(60, comb2.A);
            Assert.AreEqual(10, comb3.A);
        }
        private void InitialCombs()
        {
            comb1 = new Combinatorics(2, 1);
            comb2 = new Combinatorics(5, 3);
            comb3 = new Combinatorics(10, 1);
        }
    }
}

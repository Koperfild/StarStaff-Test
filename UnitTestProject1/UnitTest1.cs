using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IncorrectTriangle1()
        {
            FiguresOperations.Square(11, 4, 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IncorrectTriangle2()
        {
            FiguresOperations.Square(4, 11, 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IncorrectTriangle3()
        {
            FiguresOperations.Square(5, 4, 11);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeSizes1()
        {
            FiguresOperations.Square(-3, 4, 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeSizes2()
        {
            FiguresOperations.Square(3,-4,5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeSizes3()
        {
            FiguresOperations.Square(3, 4, -5);
        }
        [TestMethod]
        public void CorrectCalculation()
        {
            Assert.AreEqual(6, FiguresOperations.Square(3, 4, 5));
        }
        [TestMethod]
        public void CorrectCalculation1()
        {
            Assert.AreEqual(6, FiguresOperations.Square(4, 5, 3));
        }
        [TestMethod]
        public void CorrectCalculation2()
        {
            Assert.AreEqual(60, FiguresOperations.Square(8, 15, 17));
        }
    }
}

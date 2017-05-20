using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife.Entity;

namespace GameOfLifeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TwoDimentionalArrayOfArraysFirstAndSecondGetLengthReturnsColumnsAndRowsCorrectlyMethod()
        {
            int[,] twoDimentionalArray = new int[2, 3];
            int expectedColumnValue = 2;
            int expectedRowValue = 3;

            int actualColumnValue = twoDimentionalArray.GetLength(0);
            int actualRowValue = twoDimentionalArray.GetLength(1);

            Assert.AreEqual(expectedColumnValue, actualColumnValue);
            Assert.AreEqual(expectedRowValue, actualRowValue);
        }
    }
}

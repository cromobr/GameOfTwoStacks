using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfTwoStacksTest
{
    [TestClass]
    public class GameOfTwoStacksTest
    {
        [TestMethod]
        public void verifyCountAFalseTest()
        {
            int result = 2;
            int countA = 1;
            int position = 1;

            int value = GameOfTwoStacks.GameOfTwoStacks.verifyCountA(result,countA,position);

            Assert.AreEqual(3, value);
        }

        [TestMethod]
        public void verifyCountATrueTest()
        {
            int result = 10;
            int countA = 2;
            int position = 3;

            int value = GameOfTwoStacks.GameOfTwoStacks.verifyCountA(result, countA, position);

            Assert.AreEqual(result, value);
        }

        [TestMethod]
        public void verifyResultTrueTest()
        {
            int result = 10;
            int position = 3;

            int value = GameOfTwoStacks.GameOfTwoStacks.verifyResult(result, position);

            Assert.AreEqual(result, value);
        }

        [TestMethod]
        public void verifyResultFalseTest()
        {
            int result = 2;
            int position = 1;

            int value = GameOfTwoStacks.GameOfTwoStacks.verifyResult(result, position);

            Assert.AreEqual(2, value);
        }

        [TestMethod]
        public void convertInputToArrayTest()
        {
            string input = "1 2 3";
            int[] value = GameOfTwoStacks.GameOfTwoStacks.convertInputToArray(input);

            Assert.AreEqual(1, value[0]);
            Assert.AreEqual(2, value[1]);
            Assert.AreEqual(3, value[2]);
        }

        [TestMethod]
        public void twoStacksTest()
        {
            int x = 4;
            int[] a = new int[5] { 4, 2, 4, 6, 1 };
            int[] b = new int[4] { 2, 1, 8, 5};
            int value = GameOfTwoStacks.GameOfTwoStacks.twoStacks(x,a,b);

            Assert.AreEqual(2, value);
            
        }
    }
}

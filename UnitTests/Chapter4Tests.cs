﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olmelabs.Algorithms.Chapter4;

namespace Olmelabs.Algorithms.UnitTests
{
    [TestClass]
    public class Chapter4Tests
    {
        [TestMethod]
        public void StackCalculatorTest()
        {
            StackCalculator c = new StackCalculator();
            int res = c.Calculate("1 3 + 6 2 * 7 + *");
            Assert.AreEqual(76, res);

            res = c.Calculate("5 9 8 + 4 6 * * 7 + *");
            Assert.AreEqual(2075, res);

            res = c.Calculate("500 10 *");
            Assert.AreEqual(5000, res);
        }

        [TestMethod]
        public void StackConvertInfixToPostfixTest()
        {
            StackConvertInfixToPostfix c = new StackConvertInfixToPostfix();
            string res = c.Convert("(5*(((9+8)*(4*6))+7)");
            Assert.AreEqual("5 9 8 + 4 6 * * 7 + * ", res);
        }

        [TestMethod]
        public void FifoQueueArrayTest()
        {
            FifoQueueArray q = new FifoQueueArray(10);

            //test circular array
            for (int i = 0; i < 20; i++)
            {
                q.Put(i * 10);
            }
            

            var x = q.Get();
        }
    }
}

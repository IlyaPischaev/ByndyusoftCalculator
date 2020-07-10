using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ByndyusoftCalculator.Tests
{
    [TestClass]
    public class ReversePolishOperationsTests
    {
        [TestMethod]
        public void IsStatement_Return_True_If_Symbol_Char_Statement()
        {
            char symbol = '*';
            bool expected = true;

            ReversePolishOperations reversePolishOperations = new ReversePolishOperations();

            bool actual = reversePolishOperations.IsStatement(symbol);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsStatement_Return_True_If_Symbol_String_Statement()
        {
            string symbol = "*";
            bool expected = true;

            ReversePolishOperations reversePolishOperations = new ReversePolishOperations();

            bool actual = reversePolishOperations.IsStatement(symbol);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PriorityCheck_Return_2_If_Statement_Is_Plus_And_Minus()
        {
            char symbol = '+';
            int expected = 2;

            ReversePolishOperations reversePolishOperations = new ReversePolishOperations();

            int actual = reversePolishOperations.PriorityCheck(symbol);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PriorityCheck_Return_3_If_Statement_Is_Multiply_And_Divide()
        {
            char symbol = '*';
            int expected = 3;

            ReversePolishOperations reversePolishOperations = new ReversePolishOperations();

            int actual = reversePolishOperations.PriorityCheck(symbol);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsNumberOrFractional_Return_True_If_Symbol_Is_Number_Or_Point()
        {
            char symbol = '8';
            bool expected = true;

            ReversePolishOperations reversePolishOperations = new ReversePolishOperations();

            bool actual = reversePolishOperations.IsNumberOrFractional(symbol);
            Assert.AreEqual(expected, actual);
        }
    }
}

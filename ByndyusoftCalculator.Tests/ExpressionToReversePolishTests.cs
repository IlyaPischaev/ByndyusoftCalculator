using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ByndyusoftCalculator.Tests
{
    [TestClass]
    public class ExpressionToReversePolishTests
    {
        [TestMethod]
        public void GetReversePolish_Should_Turn_String_Expression_Without_Fractials_To_List_Reverse_Polish_Expression()
        {
            string inputExpression = "(6+10-4)/(1+1*2)+1";
            List<string> outputExpected = new List<string>()
            {
                "6",
                "10",
                "+",
                "4",
                "-",
                "1",
                "1",
                "2",
                "*",
                "+",
                "/",
                "1",
                "+"
            };

            ExpressionToReversePolish expressionToReversePolish = new ExpressionToReversePolish();
            List<string> outputActual = expressionToReversePolish.GetReversePolish(inputExpression);

            CollectionAssert.AreEqual(outputExpected, outputActual);
        }

        [TestMethod]
        public void GetReversePolish_Should_Turn_String_Expression_With_Fractials_To_List_Reverse_Polish_Expression()
        {
            string inputExpression = "(5.5+2.75*5)/(1.11+3*2.5-4.25)";
            List<string> outputExpected = new List<string>()
            {
                "5,5",
                "2,75",
                "5",
                "*",
                "+",
                "1,11",
                "3",
                "2,5",
                "*",
                "+",
                "4,25",
                "-",
                "/"
            };

            ExpressionToReversePolish expressionToReversePolish = new ExpressionToReversePolish();
            List<string> outputActual = expressionToReversePolish.GetReversePolish(inputExpression);

            CollectionAssert.AreEqual(outputExpected, outputActual);
        }
    }
}

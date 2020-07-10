using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ByndyusoftCalculator.Tests
{
    [TestClass]
    public class CalculateReversePolishTests
    {
        [TestMethod]
        public void GetCalculation_Get_String_Expression_Should_Return_5()
        {
            string expression = "(6+10-4)/(1+1*2)+1";
            double expected = 5;

            CalculateReversePolish calculateReversePolish = new CalculateReversePolish();
            double actual = calculateReversePolish.GetCalculation(expression);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCalculation_Get_String_Expression_Should_Return_Minus_5()
        {
            string expression = "-5";
            double expected = -5;

            CalculateReversePolish calculateReversePolish = new CalculateReversePolish();
            double actual = calculateReversePolish.GetCalculation(expression);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCalculation_Get_String_Expression_Should_Return_Double_4_Point_41()
        {
            string expression = "(5.5+2.75*5)/(1.11+3*2.5-4.25)";
            double expected = 4.41;

            CalculateReversePolish calculateReversePolish = new CalculateReversePolish();
            double actual = calculateReversePolish.GetCalculation(expression);

            Assert.AreEqual(expected, actual, 0.1);
        }
    }
}

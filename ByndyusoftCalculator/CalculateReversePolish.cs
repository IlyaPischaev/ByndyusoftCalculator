using System;
using System.Collections.Generic;
using System.Linq;

namespace ByndyusoftCalculator
{
    public class CalculateReversePolish
    {
        public double GetCalculation(string expression)
        {
            double result = 0;
            ExpressionToReversePolish expressionToReversePolish = new ExpressionToReversePolish();
            ReversePolishOperations reversePolishOperations = new ReversePolishOperations();
            List<string> reversePolish = expressionToReversePolish.GetReversePolish(expression);
            Stack<double> equateStack = new Stack<double>();

            foreach (string element in reversePolish)
            {
                if (reversePolishOperations.IsStatement(element))
                {
                    result = StackEquation(equateStack, element);
                    equateStack.Push(result);
                }
                else
                {
                    equateStack.Push(Convert.ToDouble(element));
                }
            }

            return result;
        }
        private double StackEquation(Stack<double> equateStack, string statement)
        {
            double result = 0;
            double lastElement = equateStack.Count > 0 ? equateStack.Pop() : 0;
            double firstElement = equateStack.Count > 0 ? equateStack.Pop() : 0;

            switch (statement)
            {
                case "+":
                    result = firstElement + lastElement;
                    break;
                case "-":
                    result = firstElement - lastElement;
                    break;
                case "*":
                    result = firstElement * lastElement;
                    break;
                case "/":
                    result = firstElement / lastElement;
                    break;
            }

            return result;
        }
    }
}

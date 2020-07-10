using System;
using System.Collections.Generic;
using System.Linq;

namespace ByndyusoftCalculator
{
    public class ExpressionToReversePolish
    {
        public List<string> GetReversePolish(string expression)
        {
            List<string> result = new List<string>();
            Stack<char> statementStack = new Stack<char>();
            expression = expression.Replace(" ", String.Empty);
            expression = expression.Replace(".", ",");
            ReversePolishOperations reversePolishOperations = new ReversePolishOperations();

            Console.WriteLine(expression);

            for (int index = 0; index < expression.Length; index++)
            {

                if (reversePolishOperations.IsNumberOrFractional(expression[index]))
                {
                    string number = String.Empty;

                    while ((index != expression.Length) && (reversePolishOperations.IsNumberOrFractional(expression[index])))
                    {
                        number += expression[index];
                        index++;
                    }

                    result.Add(number);
                    if (index == expression.Length) break;
                }

                if (reversePolishOperations.IsStatement(expression[index]))
                {
                    if (expression[index] == '(')
                    {
                        statementStack.Push(expression[index]);
                    }
                    else if (expression[index] == ')')
                    {
                        char statement = statementStack.Pop();

                        while (statement != '(')
                        {
                            result.Add(statement.ToString());
                            statement = statementStack.Pop();
                        }
                    }
                    else
                    {
                        while ((statementStack.Count != 0) && (reversePolishOperations.PriorityCheck(expression[index]) <= reversePolishOperations.PriorityCheck(statementStack.Peek())))
                        {
                            result.Add(statementStack.Pop().ToString());
                        }
                        statementStack.Push(expression[index]);
                    }
                }
            }

            while (statementStack.Count() > 0)
            {
                result.Add(statementStack.Pop().ToString());
            }

            return result;
        }
    }
}

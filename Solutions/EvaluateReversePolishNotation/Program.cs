using System;

namespace EvaluateReversePolishNotation
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var input = new string[] { "2", "1", "+", "3", "*" };
            Console.WriteLine(EvalRPN(input));  //Expected:  9 => ((2+1)*3)
        }

        //The method uses a stack data structure to store the operands as it processes the expression.
        //It loops through each token in the input array and performs the following actions:

        //If the token is an operator (+, -, *, /), the method pops the top two operands from the stack, 
        //performs the operation on them, and pushes the result back onto the stack.
        //If the token is a numeric value, it is converted to an integer and pushed onto the stack.
        //At the end of the loop, the result of the RPN expression is the only value left on the stack, and it is returned.
        
        private static int EvalRPN(string[] tokens)
        {
            var s = new Stack<int>();
        
            for(int i = 0; i < tokens.Length; i++)
            {
                if(tokens[i] == "+") s.Push(s.Pop() + s.Pop());
                else if(tokens[i] == "*") s.Push(s.Pop()*s.Pop());
                else if(tokens[i] == "-")
                {
                    int t = s.Pop();
                    s.Push(s.Pop() - t);
                }
                else if(tokens[i] == "/")
                {
                    int t = s.Pop();
                    s.Push(s.Pop()/t);
                }
                else s.Push(int.Parse(tokens[i]));
            }
        
            return s.Pop();
        }
    }
}
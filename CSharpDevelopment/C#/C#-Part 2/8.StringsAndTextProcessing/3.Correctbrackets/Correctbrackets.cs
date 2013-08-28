using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correctbrackets
{
    class Correctbrackets
    {
        static void Main(string[] args)
        {
            string expression = "((a+b)/5-d)";
            int count = 0;
            Console.WriteLine(expression);

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    count++;
                }
                else if (expression[i] == ')')
                {
                    count--;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Correct expression!");
            }
            else
            {
                Console.WriteLine("Incorrect expression!");
            }
        }

        
    }
}

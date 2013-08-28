using System;

namespace CalculatesAndPrintsSquareRoot
{
    class CalculatesAndPrintsSquareRoot
    {
        static void Main()
        {
            string a = Console.ReadLine();
            int b = 0;

            try
            {
                b = int.Parse(a);
                if (b < 0)
                {
                    throw new ArgumentException("Number might be positive!");
                }
                Console.WriteLine(b*b);
            }
            catch (ArgumentException ae)
            {
                Console.Error.WriteLine("Exception: " + ae.Message);
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("Exception: " + fe.Message);
            }
            finally 
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
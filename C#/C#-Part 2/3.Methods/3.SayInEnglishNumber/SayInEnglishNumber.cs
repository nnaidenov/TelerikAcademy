using System;

namespace SayInEnglishNumber
{
    class SayInEnglishNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int lastNum = ReturnLastDigit(number);
            SayNumberInEnglish(lastNum);
        }

        private static void SayNumberInEnglish(int lastNum)
        {
            switch (lastNum)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        static int ReturnLastDigit(int number)
        {
            string lastNum = Convert.ToString(number);

            for (int i = lastNum.Length-1; i < lastNum.Length; i++)
            {
                return Convert.ToInt32(lastNum[i]-48);
            }
            return 0;
        }
    }
}

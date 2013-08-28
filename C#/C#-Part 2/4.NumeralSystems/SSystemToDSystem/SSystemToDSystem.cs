using System;
using System.Collections.Generic;

class SSystemToDSystem
{
    static void Main()
    {
        string n = "9B";
        int s = 16;
        int d = 10;
        int decimalNum = 0;
        List<int> dSys = new List<int>();

        if (s < 10) //Convert toDecimal when S < 10
        {
            for (int i = n.Length - 1, j = 0; i >= 0; i--, j++)
            {
                int curNum = ((int)n[i] - 48) * (int)Math.Pow(s, j);
                decimalNum += curNum;
            }
        }
        else if (s > 10) //Convert toDecimal when S > 10
        {
            for (int i = n.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (n[i] == 'A')
                {
                    int curNum = 10 * (int)Math.Pow(16, j);
                    decimalNum += curNum;
                }
                else if (n[i] == 'B')
                {
                    int curNum = 11 * (int)Math.Pow(16, j);
                    decimalNum += curNum;
                }
                else if (n[i] == 'C')
                {
                    int curNum = 12 * (int)Math.Pow(16, j);
                    decimalNum += curNum;
                }
                else if (n[i] == 'D')
                {
                    int curNum = 13 * (int)Math.Pow(16, j);
                    decimalNum += curNum;
                }
                else if (n[i] == 'E')
                {
                    int curNum = 14 * (int)Math.Pow(16, j);
                    decimalNum += curNum;
                }
                else if (n[i] == 'F')
                {
                    int curNum = 15 * (int)Math.Pow(16, j);
                    decimalNum += curNum;
                }
                else
                {
                    int curNum = ((int)n[i] - 48) * (int)Math.Pow(16, j);
                    decimalNum += curNum;
                }
            }
        }

        if (d < 10) //Convert to Dsys when Dsys < 10
        {
            while (decimalNum != 0)
            {
                dSys.Add(decimalNum % d);
                decimalNum = decimalNum / d;
            }

            for (int i = dSys.Count - 1; i >= 0; i--)
            {
                Console.Write(dSys[i]);
            }
        }
        else if (d > 10)//Convert to Dsys when Dsys > 10
        {
            while (decimalNum != 0)
            {
                dSys.Add(decimalNum % d);
                decimalNum /= d;
            }

            for (int i = dSys.Count - 1; i >= 0; i--)
            {
                if (dSys[i] == 10)
                {
                    Console.Write("A");
                }
                else if (dSys[i] == 11)
                {
                    Console.Write("B");
                }
                else if (dSys[i] == 12)
                {
                    Console.Write("C");
                }
                else if (dSys[i] == 13)
                {
                    Console.Write("D");
                }
                else if (dSys[i] == 14)
                {
                    Console.Write("E");
                }
                else if (dSys[i] == 15)
                {
                    Console.Write("F");
                }
                else
                {
                    Console.Write(dSys[i]);
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(decimalNum);
        }
    }
}
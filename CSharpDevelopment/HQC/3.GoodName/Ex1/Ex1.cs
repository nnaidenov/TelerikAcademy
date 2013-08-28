using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class MyClass : Changer
    {
        const int MaxCount = 6;
        public static void Main()
        {
            Changer newChange = new Changer();
            newChange.ChangeToString(true);
        }
    }

    public class Changer
    {
        public void ChangeToString(bool input)
        {
            string result = input.ToString();
            Console.WriteLine(result);
        }
    }
}

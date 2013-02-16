using System;

class DependingOnTheUserChoice
{
    static void Main()
    {
        Console.Write("Въведи тип данни: ");
        string type = Console.ReadLine();
        Console.Write("Въведи стойност: ");
        string value = Console.ReadLine();
        
        switch (type)
        {
            case "string": Console.WriteLine("{0}*", value); ; break;
            case "str": Console.WriteLine("{0}*", value); ; break;
            case "integer": int pValue = int.Parse(value); break;
            case "int": pValue = int.Parse(value); Console.WriteLine(pValue+1); break;
            case "double": double convertValue = Convert.ToDouble(value); Console.WriteLine(convertValue+1.0); break;
            default: Console.WriteLine("Въвели сте грешeн тип данни!"); break;
        }
    }
}
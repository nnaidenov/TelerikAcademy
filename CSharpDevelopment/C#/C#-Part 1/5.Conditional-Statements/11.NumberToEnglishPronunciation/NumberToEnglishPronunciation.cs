using System;

class NumberToEnglishPronunciation
{
    static void Main()
    {
        Console.Write("Въведете число между 0 и 999: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Your number is {0} - ", a);
        if (a - 900 >= 0)
        {
            string ninehundret = "Nine hundred";
            int aHundred = a - 900;
            if (aHundred - 90 >= 0)
            {
                string tenth = "ninty";
                int aFinal = aHundred - 90;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 80 >= 0)
            {
                string tenth = "eighty";
                int aFinal = aHundred - 80;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 70 >= 0)
            {
                string tenth = "sevesnty";
                int aFinal = aHundred - 70;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 60 >= 0)
            {
                string tenth = "sixty";
                int aFinal = aHundred - 60;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 50 >= 0)
            {
                string tenth = "fifty";
                int aFinal = aHundred - 50;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 40 >= 0)
            {
                string tenth = "fourty";
                int aFinal = aHundred - 40;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 30 >= 0)
            {
                string tenth = "thirty";
                int aFinal = aHundred - 30;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 20 >= 0)
            {
                string tenth = "twenty";
                int aFinal = aHundred - 20;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 10 >= 0)
            {
                int aFinal = aHundred - 10;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and ninteen.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eighteen.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seventeen.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and sixteen.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and fifteen.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and fourteen.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and thirteen.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and twelve.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and eleven.", ninehundret); break;
                    case 0: Console.WriteLine("{0} and ten.", ninehundret); break;
                }
            }
            else
            {
                int aFinal = aHundred;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and nine.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eight.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seven.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and six.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and five.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and four.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and three.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and two.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and one.", ninehundret); break;
                    case 0: Console.WriteLine("{0}.", ninehundret); break;
                }
            }
        }
        else if (a - 800 >= 0)
        {
            string ninehundret = "Eight hundred";
            int aHundred = a - 800;
            if (aHundred - 90 >= 0)
            {
                string tenth = "ninty";
                int aFinal = aHundred - 90;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 80 >= 0)
            {
                string tenth = "eighty";
                int aFinal = aHundred - 80;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 70 >= 0)
            {
                string tenth = "sevesnty";
                int aFinal = aHundred - 70;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 60 >= 0)
            {
                string tenth = "sixty";
                int aFinal = aHundred - 60;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 50 >= 0)
            {
                string tenth = "fifty";
                int aFinal = aHundred - 50;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 40 >= 0)
            {
                string tenth = "fourty";
                int aFinal = aHundred - 40;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 30 >= 0)
            {
                string tenth = "thirty";
                int aFinal = aHundred - 30;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 20 >= 0)
            {
                string tenth = "twenty";
                int aFinal = aHundred - 20;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 10 >= 0)
            {
                int aFinal = aHundred - 10;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and ninteen.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eighteen.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seventeen.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and sixteen.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and fifteen.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and fourteen.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and thirteen.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and twelve.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and eleven.", ninehundret); break;
                    case 0: Console.WriteLine("{0} and ten.", ninehundret); break;
                }
            }
            else
            {
                int aFinal = aHundred;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and nine.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eight.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seven.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and six.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and five.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and four.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and three.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and two.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and one.", ninehundret); break;
                    case 0: Console.WriteLine("{0}.", ninehundret); break;
                }
            }
        }
        else if (a - 700 >= 0)
        {
            string ninehundret = "Seven hundred";
            int aHundred = a - 700;
            if (aHundred - 90 >= 0)
            {
                string tenth = "ninty";
                int aFinal = aHundred - 90;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 80 >= 0)
            {
                string tenth = "eighty";
                int aFinal = aHundred - 80;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 70 >= 0)
            {
                string tenth = "sevesnty";
                int aFinal = aHundred - 70;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 60 >= 0)
            {
                string tenth = "sixty";
                int aFinal = aHundred - 60;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 50 >= 0)
            {
                string tenth = "fifty";
                int aFinal = aHundred - 50;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 40 >= 0)
            {
                string tenth = "fourty";
                int aFinal = aHundred - 40;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 30 >= 0)
            {
                string tenth = "thirty";
                int aFinal = aHundred - 30;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 20 >= 0)
            {
                string tenth = "twenty";
                int aFinal = aHundred - 20;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 10 >= 0)
            {
                int aFinal = aHundred - 10;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and ninteen.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eighteen.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seventeen.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and sixteen.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and fifteen.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and fourteen.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and thirteen.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and twelve.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and eleven.", ninehundret); break;
                    case 0: Console.WriteLine("{0} and ten.", ninehundret); break;
                }
            }
            else
            {
                int aFinal = aHundred;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and nine.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eight.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seven.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and six.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and five.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and four.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and three.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and two.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and one.", ninehundret); break;
                    case 0: Console.WriteLine("{0}.", ninehundret); break;
                }
            }
        }
        else if (a - 600 >= 0)
        {
            string ninehundret = "Six hundred";
            int aHundred = a - 600;
            if (aHundred - 90 >= 0)
            {
                string tenth = "ninty";
                int aFinal = aHundred - 90;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 80 >= 0)
            {
                string tenth = "eighty";
                int aFinal = aHundred - 80;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 70 >= 0)
            {
                string tenth = "sevesnty";
                int aFinal = aHundred - 70;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 60 >= 0)
            {
                string tenth = "sixty";
                int aFinal = aHundred - 60;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 50 >= 0)
            {
                string tenth = "fifty";
                int aFinal = aHundred - 50;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 40 >= 0)
            {
                string tenth = "fourty";
                int aFinal = aHundred - 40;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 30 >= 0)
            {
                string tenth = "thirty";
                int aFinal = aHundred - 30;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 20 >= 0)
            {
                string tenth = "twenty";
                int aFinal = aHundred - 20;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 10 >= 0)
            {
                int aFinal = aHundred - 10;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and ninteen.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eighteen.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seventeen.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and sixteen.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and fifteen.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and fourteen.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and thirteen.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and twelve.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and eleven.", ninehundret); break;
                    case 0: Console.WriteLine("{0} and ten.", ninehundret); break;
                }
            }
            else
            {
                int aFinal = aHundred;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and nine.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eight.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seven.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and six.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and five.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and four.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and three.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and two.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and one.", ninehundret); break;
                    case 0: Console.WriteLine("{0}.", ninehundret); break;
                }
            }
        }
        else if (a - 500 >= 0)
        {
            string ninehundret = "Five hundred";
            int aHundred = a - 500;
            if (aHundred - 90 >= 0)
            {
                string tenth = "ninty";
                int aFinal = aHundred - 90;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 80 >= 0)
            {
                string tenth = "eighty";
                int aFinal = aHundred - 80;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 70 >= 0)
            {
                string tenth = "sevesnty";
                int aFinal = aHundred - 70;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 60 >= 0)
            {
                string tenth = "sixty";
                int aFinal = aHundred - 60;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 50 >= 0)
            {
                string tenth = "fifty";
                int aFinal = aHundred - 50;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 40 >= 0)
            {
                string tenth = "fourty";
                int aFinal = aHundred - 40;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 30 >= 0)
            {
                string tenth = "thirty";
                int aFinal = aHundred - 30;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 20 >= 0)
            {
                string tenth = "twenty";
                int aFinal = aHundred - 20;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 10 >= 0)
            {
                int aFinal = aHundred - 10;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and ninteen.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eighteen.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seventeen.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and sixteen.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and fifteen.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and fourteen.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and thirteen.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and twelve.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and eleven.", ninehundret); break;
                    case 0: Console.WriteLine("{0} and ten.", ninehundret); break;
                }
            }
            else
            {
                int aFinal = aHundred;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and nine.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eight.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seven.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and six.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and five.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and four.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and three.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and two.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and one.", ninehundret); break;
                    case 0: Console.WriteLine("{0}.", ninehundret); break;
                }
            }
        }
        else if (a - 400 >= 0)
        {
            string ninehundret = "Four hundred";
            int aHundred = a - 400;
            if (aHundred - 90 >= 0)
            {
                string tenth = "ninty";
                int aFinal = aHundred - 90;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 80 >= 0)
            {
                string tenth = "eighty";
                int aFinal = aHundred - 80;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 70 >= 0)
            {
                string tenth = "sevesnty";
                int aFinal = aHundred - 70;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 60 >= 0)
            {
                string tenth = "sixty";
                int aFinal = aHundred - 60;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 50 >= 0)
            {
                string tenth = "fifty";
                int aFinal = aHundred - 50;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 40 >= 0)
            {
                string tenth = "fourty";
                int aFinal = aHundred - 40;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 30 >= 0)
            {
                string tenth = "thirty";
                int aFinal = aHundred - 30;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 20 >= 0)
            {
                string tenth = "twenty";
                int aFinal = aHundred - 20;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 10 >= 0)
            {
                int aFinal = aHundred - 10;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and ninteen.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eighteen.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seventeen.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and sixteen.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and fifteen.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and fourteen.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and thirteen.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and twelve.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and eleven.", ninehundret); break;
                    case 0: Console.WriteLine("{0} and ten.", ninehundret); break;
                }
            }
            else
            {
                int aFinal = aHundred;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and nine.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eight.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seven.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and six.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and five.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and four.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and three.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and two.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and one.", ninehundret); break;
                    case 0: Console.WriteLine("{0}.", ninehundret); break;
                }
            }
        }
        else if (a - 300 >= 0)
        {
            string ninehundret = "Three hundred";
            int aHundred = a - 300;
            if (aHundred - 90 >= 0)
            {
                string tenth = "ninty";
                int aFinal = aHundred - 90;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 80 >= 0)
            {
                string tenth = "eighty";
                int aFinal = aHundred - 80;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 70 >= 0)
            {
                string tenth = "sevesnty";
                int aFinal = aHundred - 70;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 60 >= 0)
            {
                string tenth = "sixty";
                int aFinal = aHundred - 60;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 50 >= 0)
            {
                string tenth = "fifty";
                int aFinal = aHundred - 50;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 40 >= 0)
            {
                string tenth = "fourty";
                int aFinal = aHundred - 40;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 30 >= 0)
            {
                string tenth = "thirty";
                int aFinal = aHundred - 30;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 20 >= 0)
            {
                string tenth = "twenty";
                int aFinal = aHundred - 20;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 10 >= 0)
            {
                int aFinal = aHundred - 10;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and ninteen.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eighteen.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seventeen.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and sixteen.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and fifteen.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and fourteen.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and thirteen.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and twelve.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and eleven.", ninehundret); break;
                    case 0: Console.WriteLine("{0} and ten.", ninehundret); break;
                }
            }
            else
            {
                int aFinal = aHundred;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and nine.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eight.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seven.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and six.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and five.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and four.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and three.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and two.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and one.", ninehundret); break;
                    case 0: Console.WriteLine("{0}.", ninehundret); break;
                }
            }
        }
        else if (a - 200 >= 0)
        {
            string ninehundret = "Two hundred";
            int aHundred = a - 200;
            if (aHundred - 90 >= 0)
            {
                string tenth = "ninty";
                int aFinal = aHundred - 90;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 80 >= 0)
            {
                string tenth = "eighty";
                int aFinal = aHundred - 80;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 70 >= 0)
            {
                string tenth = "sevesnty";
                int aFinal = aHundred - 70;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 60 >= 0)
            {
                string tenth = "sixty";
                int aFinal = aHundred - 60;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 50 >= 0)
            {
                string tenth = "fifty";
                int aFinal = aHundred - 50;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 40 >= 0)
            {
                string tenth = "fourty";
                int aFinal = aHundred - 40;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 30 >= 0)
            {
                string tenth = "thirty";
                int aFinal = aHundred - 30;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 20 >= 0)
            {
                string tenth = "twenty";
                int aFinal = aHundred - 20;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 10 >= 0)
            {
                int aFinal = aHundred - 10;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and ninteen.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eighteen.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seventeen.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and sixteen.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and fifteen.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and fourteen.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and thirteen.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and twelve.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and eleven.", ninehundret); break;
                    case 0: Console.WriteLine("{0} and ten.", ninehundret); break;
                }
            }
            else
            {
                int aFinal = aHundred;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and nine.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eight.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seven.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and six.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and five.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and four.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and three.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and two.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and one.", ninehundret); break;
                    case 0: Console.WriteLine("{0}.", ninehundret); break;
                }
            }
        }
        else if (a - 100 >= 0)
        {
            string ninehundret = "One hundred";
            int aHundred = a - 100;
            if (aHundred - 90 >= 0)
            {
                string tenth = "ninty";
                int aFinal = aHundred - 90;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 80 >= 0)
            {
                string tenth = "eighty";
                int aFinal = aHundred - 80;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 70 >= 0)
            {
                string tenth = "sevesnty";
                int aFinal = aHundred - 70;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 60 >= 0)
            {
                string tenth = "sixty";
                int aFinal = aHundred - 60;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 50 >= 0)
            {
                string tenth = "fifty";
                int aFinal = aHundred - 50;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 40 >= 0)
            {
                string tenth = "fourty";
                int aFinal = aHundred - 40;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 30 >= 0)
            {
                string tenth = "thirty";
                int aFinal = aHundred - 30;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 20 >= 0)
            {
                string tenth = "twenty";
                int aFinal = aHundred - 20;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} {1} nine.", ninehundret, tenth); break;
                    case 8: Console.WriteLine("{0} {1} eight.", ninehundret, tenth); break;
                    case 7: Console.WriteLine("{0} {1} seven.", ninehundret, tenth); break;
                    case 6: Console.WriteLine("{0} {1} six.", ninehundret, tenth); break;
                    case 5: Console.WriteLine("{0} {1} five.", ninehundret, tenth); break;
                    case 4: Console.WriteLine("{0} {1} four.", ninehundret, tenth); break;
                    case 3: Console.WriteLine("{0} {1} three.", ninehundret, tenth); break;
                    case 2: Console.WriteLine("{0} {1} two.", ninehundret, tenth); break;
                    case 1: Console.WriteLine("{0} {1} one.", ninehundret, tenth); break;
                    case 0: Console.WriteLine("{0} and {1}.", ninehundret, tenth); break;
                }
            }
            else if (aHundred - 10 >= 0)
            {
                int aFinal = aHundred - 10;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and ninteen.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eighteen.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seventeen.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and sixteen.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and fifteen.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and fourteen.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and thirteen.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and twelve.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and eleven.", ninehundret); break;
                    case 0: Console.WriteLine("{0} and ten.", ninehundret); break;
                }
            }
            else
            {
                int aFinal = aHundred;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} and nine.", ninehundret); break;
                    case 8: Console.WriteLine("{0} and eight.", ninehundret); break;
                    case 7: Console.WriteLine("{0} and seven.", ninehundret); break;
                    case 6: Console.WriteLine("{0} and six.", ninehundret); break;
                    case 5: Console.WriteLine("{0} and five.", ninehundret); break;
                    case 4: Console.WriteLine("{0} and four.", ninehundret); break;
                    case 3: Console.WriteLine("{0} and three.", ninehundret); break;
                    case 2: Console.WriteLine("{0} and two.", ninehundret); break;
                    case 1: Console.WriteLine("{0} and one.", ninehundret); break;
                    case 0: Console.WriteLine("{0}.", ninehundret); break;
                }
            }
        }
        else
        {
            if (a - 90 >= 0)
            {
                string tenth = "Ninty";
                int aFinal = a - 90;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} nine.", tenth); break;
                    case 8: Console.WriteLine("{0} eight.", tenth); break;
                    case 7: Console.WriteLine("{0} seven.", tenth); break;
                    case 6: Console.WriteLine("{0} six.", tenth); break;
                    case 5: Console.WriteLine("{0} five.", tenth); break;
                    case 4: Console.WriteLine("{0} four.", tenth); break;
                    case 3: Console.WriteLine("{0} three.", tenth); break;
                    case 2: Console.WriteLine("{0} two.", tenth); break;
                    case 1: Console.WriteLine("{0} one.", tenth); break;
                    case 0: Console.WriteLine("{0}.", tenth); break;
                }
            }
            else if (a - 80 >= 0)
            {
                string tenth = "Eighty";
                int aFinal = a - 80;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} nine.", tenth); break;
                    case 8: Console.WriteLine("{0} eight.", tenth); break;
                    case 7: Console.WriteLine("{0} seven.", tenth); break;
                    case 6: Console.WriteLine("{0} six.", tenth); break;
                    case 5: Console.WriteLine("{0} five.", tenth); break;
                    case 4: Console.WriteLine("{0} four.", tenth); break;
                    case 3: Console.WriteLine("{0} three.", tenth); break;
                    case 2: Console.WriteLine("{0} two.", tenth); break;
                    case 1: Console.WriteLine("{0} one.", tenth); break;
                    case 0: Console.WriteLine("{0}.", tenth); break;
                }
            }
            else if (a - 70 >= 0)
            {
                string tenth = "Seventy";
                int aFinal = a - 70;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} nine.", tenth); break;
                    case 8: Console.WriteLine("{0} eight.", tenth); break;
                    case 7: Console.WriteLine("{0} seven.", tenth); break;
                    case 6: Console.WriteLine("{0} six.", tenth); break;
                    case 5: Console.WriteLine("{0} five.", tenth); break;
                    case 4: Console.WriteLine("{0} four.", tenth); break;
                    case 3: Console.WriteLine("{0} three.", tenth); break;
                    case 2: Console.WriteLine("{0} two.", tenth); break;
                    case 1: Console.WriteLine("{0} one.", tenth); break;
                    case 0: Console.WriteLine("{0}.", tenth); break;
                }
            }
            else if (a - 60 >= 0)
            {
                string tenth = "Sixty";
                int aFinal = a - 60;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} nine.", tenth); break;
                    case 8: Console.WriteLine("{0} eight.", tenth); break;
                    case 7: Console.WriteLine("{0} seven.", tenth); break;
                    case 6: Console.WriteLine("{0} six.", tenth); break;
                    case 5: Console.WriteLine("{0} five.", tenth); break;
                    case 4: Console.WriteLine("{0} four.", tenth); break;
                    case 3: Console.WriteLine("{0} three.", tenth); break;
                    case 2: Console.WriteLine("{0} two.", tenth); break;
                    case 1: Console.WriteLine("{0} one.", tenth); break;
                    case 0: Console.WriteLine("{0}.", tenth); break;
                }
            }
            else if (a - 50 >= 0)
            {
                string tenth = "Fifty";
                int aFinal = a - 50;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} nine.", tenth); break;
                    case 8: Console.WriteLine("{0} eight.", tenth); break;
                    case 7: Console.WriteLine("{0} seven.", tenth); break;
                    case 6: Console.WriteLine("{0} six.", tenth); break;
                    case 5: Console.WriteLine("{0} five.", tenth); break;
                    case 4: Console.WriteLine("{0} four.", tenth); break;
                    case 3: Console.WriteLine("{0} three.", tenth); break;
                    case 2: Console.WriteLine("{0} two.", tenth); break;
                    case 1: Console.WriteLine("{0} one.", tenth); break;
                    case 0: Console.WriteLine("{0}.", tenth); break;
                }
            }
            else if (a - 40 >= 0)
            {
                string tenth = "Fourty";
                int aFinal = a - 40;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} nine.", tenth); break;
                    case 8: Console.WriteLine("{0} eight.", tenth); break;
                    case 7: Console.WriteLine("{0} seven.", tenth); break;
                    case 6: Console.WriteLine("{0} six.", tenth); break;
                    case 5: Console.WriteLine("{0} five.", tenth); break;
                    case 4: Console.WriteLine("{0} four.", tenth); break;
                    case 3: Console.WriteLine("{0} three.", tenth); break;
                    case 2: Console.WriteLine("{0} two.", tenth); break;
                    case 1: Console.WriteLine("{0} one.", tenth); break;
                    case 0: Console.WriteLine("{0}.", tenth); break;
                }
            }
            else if (a - 30 >= 0)
            {
                string tenth = "Thirty";
                int aFinal = a - 30;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} nine.", tenth); break;
                    case 8: Console.WriteLine("{0} eight.", tenth); break;
                    case 7: Console.WriteLine("{0} seven.", tenth); break;
                    case 6: Console.WriteLine("{0} six.", tenth); break;
                    case 5: Console.WriteLine("{0} five.", tenth); break;
                    case 4: Console.WriteLine("{0} four.", tenth); break;
                    case 3: Console.WriteLine("{0} three.", tenth); break;
                    case 2: Console.WriteLine("{0} two.", tenth); break;
                    case 1: Console.WriteLine("{0} one.", tenth); break;
                    case 0: Console.WriteLine("{0}.", tenth); break;
                }
            }
            else if (a - 20 >= 0)
            {
                string tenth = "Twenty";
                int aFinal = a - 20;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("{0} nine.", tenth); break;
                    case 8: Console.WriteLine("{0} eight.", tenth); break;
                    case 7: Console.WriteLine("{0} seven.", tenth); break;
                    case 6: Console.WriteLine("{0} six.", tenth); break;
                    case 5: Console.WriteLine("{0} five.", tenth); break;
                    case 4: Console.WriteLine("{0} four.", tenth); break;
                    case 3: Console.WriteLine("{0} three.", tenth); break;
                    case 2: Console.WriteLine("{0} two.", tenth); break;
                    case 1: Console.WriteLine("{0} one.", tenth); break;
                    case 0: Console.WriteLine("{0}.", tenth); break;
                }
            }
            else if (a - 10 >= 0)
            {
                int aFinal = a - 10;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("Ninteen"); break;
                    case 8: Console.WriteLine("Eighteen."); break;
                    case 7: Console.WriteLine("Seventeen."); break;
                    case 6: Console.WriteLine("Sixteen."); break;
                    case 5: Console.WriteLine("Fifteen."); break;
                    case 4: Console.WriteLine("Fourteen."); break;
                    case 3: Console.WriteLine("Thirteen."); break;
                    case 2: Console.WriteLine("Twelve."); break;
                    case 1: Console.WriteLine("Eleven."); break;
                    case 0: Console.WriteLine("Ten."); break;
                }
            }
            else
            {
                int aFinal = a;
                switch (aFinal)
                {
                    case 9: Console.WriteLine("Nine."); break;
                    case 8: Console.WriteLine("Eight."); break;
                    case 7: Console.WriteLine("Seven."); break;
                    case 6: Console.WriteLine("Six."); break;
                    case 5: Console.WriteLine("Five."); break;
                    case 4: Console.WriteLine("Four."); break;
                    case 3: Console.WriteLine("Three."); break;
                    case 2: Console.WriteLine("Two."); break;
                    case 1: Console.WriteLine("One."); break;
                    case 0: Console.WriteLine("Zero."); break;
                }
            }
        }
    }
}
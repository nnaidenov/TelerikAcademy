using System;

class ShowDeckOfCards
{
    static void Main()
    {
        string cardsName = "";
        char cardsColor = 'a';
        for (int j = 0; j < 4; j++)
        {
            for (int i = 2; i < 15; i++)
            {
                switch (i)
                {
                    case 2: cardsName = "2"; break;
                    case 3: cardsName = "3"; break;
                    case 4: cardsName = "4"; break;
                    case 5: cardsName = "5"; break;
                    case 6: cardsName = "6"; break;
                    case 7: cardsName = "7"; break;
                    case 8: cardsName = "8"; break;
                    case 9: cardsName = "9"; break;
                    case 10: cardsName = "10"; break;
                    case 11: cardsName = "J"; break;
                    case 12: cardsName = "Q"; break;
                    case 13: cardsName = "K"; break;
                    case 14: cardsName = "A"; break;
                }
                switch (j)
                {
                    case 0: cardsColor = '\u2660'; break;
                    case 1: cardsColor = '\u2663'; break;
                    case 2: cardsColor = '\u2665'; break;
                    case 3: cardsColor = '\u2666'; break;
                }
                Console.Write("{1}{0} ", cardsName, cardsColor);
            }
        }
    }
}

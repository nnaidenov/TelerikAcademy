using System;

class PointInCircleAndRectangle
{
    static void Main()
    {
        Console.WriteLine("Въведете стойност x за точка А: ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведете стойност y за точка А: ");
        decimal y = decimal.Parse(Console.ReadLine());

        decimal kx = 1.1m;
        decimal ky = 3;

        decimal ax = 0;
        decimal ay = -1;
        decimal dx = 0;
        decimal dy = 1;

        decimal bx = ax + 6;
        decimal by = ay;       
        decimal cx = dx + 6;
        decimal cy = dy;

        decimal kr = ky - kx;
        bool aInCircle = (kr * kr) >= (x * x) + (y * y);
        bool aInAtoBx = x >= ax && x <= bx;
        bool aInDtoCx = x >= dx && x <= cx;
        bool aInAtoBy = y >= ay && y >= by;
        bool aInDtoCy = y <= dy && y <= cy;

        if(aInCircle == true)
        {
            if (aInAtoBx && aInDtoCx && aInAtoBy && aInDtoCy)
            {
                Console.WriteLine("Условието не е изпълнено!");
            }
            else
            {
                Console.WriteLine("Условието е изпълнено!");
            }
        }
        else
        {
            Console.WriteLine("Условието не е изпълнено!");
        }
    }
}

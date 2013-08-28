using System;

class GetAndSetBitsOnPositions
{
    static void Main()
    {
        Console.Write("Въведете число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Числото в двоична бройна система изглежда така: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

        //Взимам бит на позиция 4
        int mask4 = 1 << 4;
        int nAndMask = n & mask4;
        int bit4 = nAndMask >> 4;

        //Взимам бит на позиция 5
        int mask5 = 1 << 5;
        nAndMask = n & mask5;
        int bit5 = nAndMask >> 5;

        //Взимам бит на позиция 6
        int mask6 = 1 << 6;
        nAndMask = n & mask6;
        int bit6 = nAndMask >> 6;

        //Взимам бит на позиция 24
        int mask24 = 1 << 24;
        nAndMask = n & mask24;
        int bit24 = nAndMask >> 24;

        //Взимам бит на позиция 25
        int mask25 = 1 << 25;
        nAndMask = n & mask25;
        int bit25 = nAndMask >> 25;
        
        //Взимам бит на позиция 26
        int mask26 = 1 << 26;
        nAndMask = n & mask26;
        int bit26 = nAndMask >> 26;

        //Зануляване на бит 4
        int mask0 = ~(1 << 4);
        int result4 = n & mask0;
        //Зануляване на бит 5
        mask0 = ~(1 << 5);
        int result5 = n & mask0;
        //Зануляване на бит 6
        mask0 = ~(1 << 6);
        int result6 = n & mask0;
        //Зануляване на бит 24
        mask0 = ~(1 << 24);
        int result24 = n & mask0;
        //Зануляване на бит 25
        mask0 = ~(1 << 25);
        int result25 = n & mask0;
        //Зануляване на бит 26
        mask0 = ~(1 << 26);
        int result26 = n & mask0;

        //Зануляване на битовете в числото
        int finalResult0 = result4 & result5 & result6 & result24 & result25 & result26;

        //Позициониране на битовете
        int resultBit24To4 = bit24 << 4;
        int resultBit25To5 = bit25 << 5;
        int resultBit26To6 = bit26 << 6;
        int resultBit4To24 = bit4 << 24;
        int resultBit5To25 = bit5 << 25;
        int resultBit6To26 = bit6 << 26;

        //Заместване на старите битове с нови
        int result = finalResult0 ^ resultBit24To4 ^ resultBit25To5 ^ resultBit26To6 ^ resultBit4To24 ^ resultBit5To25 ^ resultBit6To26;
        Console.WriteLine("След смяната на битовете числото изглежда така: {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("Бит 4: {0}\nБит 5: {1}\nБит 6: {2}\nБит 24: {3}\nБит 25: {4}\nБит 26: {5}", bit4, bit5, bit6, bit24, bit25, bit26);
    }
}
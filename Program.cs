using System;

class Program
{
    static void Main()
    {
        double B1, B2, B3;

        Console.WriteLine("Enter the three initial balances:");
        B1 = double.Parse(Console.ReadLine());
        B2 = double.Parse(Console.ReadLine());
        B3 = double.Parse(Console.ReadLine());

        double L = 0;

        while (true)
        {
            double payment = double.Parse(Console.ReadLine());

            if (payment <= 0)
                break;

            if (B1 >= payment)
            {
                B1 -= payment;
            }
            else if (B2 >= payment)
            {
                B2 -= payment;
            }
            else if (B3 >= payment)
            {
                B3 -= payment;
            }
            else
            {
                L += payment;
            }
        }

        Console.WriteLine("Balance 1: {0}, Balance 2: {1}, Balance 3: {2}", B1, B2, B3);
        if(L>0)
        {
        Console.WriteLine("Left: {0}", L);
        }
    }
}

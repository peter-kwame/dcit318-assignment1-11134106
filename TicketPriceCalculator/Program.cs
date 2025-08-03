using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        int price;

        if (age <= 12 || age >= 65)
        {
            price = 7;
        }
        else
        {
            price = 10;
        }

        Console.WriteLine("Your ticket price is GHC" + price);
    }
}

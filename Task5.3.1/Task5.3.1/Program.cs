using System;


class MainClass
{
    static void Main(string[] args)
    {
        var number = 15;

        Console.WriteLine(number);
        ChangeAge(ref number);
        Console.WriteLine(number);
            

    }
    static void ChangeAge(ref int  age)
    {
        Console.WriteLine("Введите свой возраст: ");
        age = System.Convert.ToInt32( Console.ReadLine());
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

class Challenges
{
    private const bool V = true;

    public static void Main()
    {

        Console.WriteLine("Welcome to my coding challenge program. There will be a variety of different funtions you will have to choose from. Please pick one.");

        Console.WriteLine("Today we are going to use the number adder called SUM. Please input two numbers for us to add. \n");
        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);
        Console.WriteLine("Awesome! Please input a second number");
        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);
        Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(number1int, number2int));
        Sum(number1int, number2int);

        Console.WriteLine("Lets try converting minutes to seconds. \nGive me a number to convert from minutes to seconds");
        var number3 = Console.ReadLine();
        int number3int = int.Parse(number3);
        Console.WriteLine(number3 + " minutes to seconds is equal to: " + Convert(number3int));

        Console.WriteLine("Let's increase a number by one. \nPlease pick a number");
        var number4 = Console.ReadLine();
        int number4int = int.Parse(number4);
        Console.WriteLine(number4 + " plus one equals: " + PlusOne(number4int));

        Console.WriteLine("Let's take the voltage power times the current power to give us a circuit number. \nPlease provide a voltage number");
        var number5 = Console.ReadLine();
        int number5int = int.Parse(number5);
        Console.WriteLine("Please pick a current number");
        var number6 = Console.ReadLine();
        int number6int = int.Parse(number6);
        Console.WriteLine(number5 + " multiplied by " + number6 + " is: " + CircuitPower(number5int, number6int));

        Console.WriteLine("Today we are converting years to days. \nPlease give us an age");
        var number7 = Console.ReadLine();
        int number7int = int.Parse(number7);
        Console.WriteLine(number7 + " years converted into days is: " + CalcAge(number7int));

        Console.WriteLine("Today we are finding the area of a triange. \nPlease provide the base of the triangle");
        var number8 = Console.ReadLine();
        float number8int = int.Parse(number8);
        Console.WriteLine("Please provide the height of the triangle");
        var number9 = Console.ReadLine();
        Console.WriteLine("The area of the triangle is: " + triArea(number8int, int.Parse(number9)));
        
        Console.WriteLine("Today we are finding out if a number is less than or equal to 0. \nPlease provide a number");
        var number10 = Console.ReadLine();
        bool number10bool = bool.Parse(number10);
        Console.WriteLine(isLessThanOrEqualToZero(-5));  // True
        Console.WriteLine(isLessThanOrEqualToZero(0));   // True
        Console.WriteLine(isLessThanOrEqualToZero(5));   // False
    }
   


    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Convert(int number3)
    {
        return number3 * 60;
    }

    public static int PlusOne(int number4)
    {
        return number4 + 1;
    }

    public static int CircuitPower(int number5, int number6)
    {
        return number5 * number6;
    }
       
    public static int CalcAge(int number7)
    {
        return number7 * 365;
    }

    public static float triArea(float number8, int number9)
    {
        return (number8 * number9) / 2;
    }

    public static bool isLessThanOrEqualToZero(int number10)
    {
        return number10 == V;
    }
}


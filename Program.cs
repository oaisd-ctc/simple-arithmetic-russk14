// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args)
    {

        // Addition

        Console.WriteLine("Provide a number to perform addition: ");
        float firstAdd = float.Parse(Console.ReadLine());

        Console.WriteLine("Alright your first number is " + firstAdd + ", what do you want to add to it?: ");
        float secondAdd = float.Parse(Console.ReadLine());

        float sum = firstAdd + secondAdd;

        Console.WriteLine("Calculating Result...!");
        Console.WriteLine("The sum of " + firstAdd + " + " + secondAdd + " is " + sum + "!");

        // Subtraction

        Console.WriteLine("Provide a number to perform subtraction from");
        float firstSub = float.Parse(Console.ReadLine());

        Console.WriteLine("Alright your first number is " + firstSub + ", what do you want to subtract from it?: ");
        float secondSub = float.Parse(Console.ReadLine());

        float difference = firstSub - secondSub;

        Console.WriteLine("Calculating Result...!");
        Console.WriteLine("The difference of " + firstSub + " - " + secondSub + " is " + difference + "!");

        // Multiplication

        Console.WriteLine("More difficult calculations! Provide a number to multiply: ");
        float firstMult = float.Parse(Console.ReadLine());

        Console.WriteLine("Provide the second co-efficient to multiply with: ");
        float secondMult = float.Parse(Console.ReadLine());

        float product = firstMult * secondMult;

        Console.WriteLine("Calculating Result...!");
        Console.WriteLine("The product of " + firstMult + " x " + secondMult + " is " + product + "!");

        // Division

        Console.WriteLine("Dreaded divison... Provide a number to be divided by: ");
        float firstDiv = float.Parse(Console.ReadLine());

        Console.WriteLine("Provide the second value as the divisor to divide the first number: ");
        float secondDiv = float.Parse(Console.ReadLine());

        float quotient = firstDiv / secondDiv;

        Console.WriteLine("Calculating Result...!");
        Console.WriteLine("The product of " + firstDiv + " / " + secondDiv + " is " + quotient + "!");

    }
}
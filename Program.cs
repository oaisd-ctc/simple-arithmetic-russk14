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

        Console.WriteLine("Provide the second co-efficient to multiply " + firstMult + " by: ");
        float secondMult = float.Parse(Console.ReadLine());

        float product = firstMult * secondMult;

        Console.WriteLine("Calculating Result...!");
        Console.WriteLine("The product of " + firstMult + " x " + secondMult + " is " + product + "!");

        // Decimal Division

        Console.WriteLine("Dreaded divison... Provide a number to be divided by: ");
        float firstDiv = float.Parse(Console.ReadLine());

        Console.WriteLine("Provide the second value as the divisor to divide " + firstDiv + " by: ");
        float secondDiv = float.Parse(Console.ReadLine());

        float quotient = firstDiv / secondDiv;

        Console.WriteLine("Calculating Result...!");
        Console.WriteLine("The product of " + firstDiv + " / " + secondDiv + " is " + quotient + "!");

        // Integer Division

        Console.WriteLine("How about we try some division without those decimal results?");

        Console.WriteLine("Provide the first integer for integer division!: ");
        int firstInt = int.Parse(Console.ReadLine());

        Console.WriteLine("Provide the second integer as the divisor of " + firstInt + ":");
        int secondInt = int.Parse(Console.ReadLine());

        int intQuotient = firstInt / secondInt;

        Console.WriteLine("Calculating Result...!");
        Console.WriteLine("The quotient for the integer division of " + firstInt + " by " + secondInt + " is " + intQuotient + "!");

        // Modulo

        Console.WriteLine("How about we try a CSS special... Modulus!");
        
        Console.WriteLine("Provide the first number to see if the second number will go in perfectly!: ");
        int firstMod = int.Parse(Console.ReadLine());

        Console.WriteLine("Provide the second number to mod " + firstMod + " by: ");
        int secondMod = int.Parse(Console.ReadLine());

        int modResult = firstMod % secondMod;

        Console.WriteLine("Calculating Result...!");
        Console.WriteLine("The modulus result of " + firstMod + " mod " + secondMod + " is " + modResult + "!");


    }
}
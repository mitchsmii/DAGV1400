using System;

class Program
{
    static void Main()
    {

        // Declare and initialize variables of different data types
        int integerVariable = 10;
        float floatVariable = 3.14f;
        bool booleanVariable = true;
        string stringVariable = "Hello, World!";


        // Display the values of variables on the console
        Console.WriteLine("Challenge 1");
        Console.WriteLine($"Integer Variable: {integerVariable}");
        Console.WriteLine($"Float Variable: {floatVariable}");
        Console.WriteLine($"Boolean Variable: {booleanVariable}");
        Console.WriteLine($"String Variable: {stringVariable}");
        Console.WriteLine();


        // Perform arithmetic operations on numeric variables
        int resultAddition = integerVariable + 5;
        float resultSubtraction = floatVariable - 2.5f;
        int resultMultiplication = integerVariable * 3;
        float resultDivision = floatVariable / 2;


        // Display the results of arithmetic operations
        Console.WriteLine("Challenge 2");
        Console.WriteLine($"Addition Result: {resultAddition}");
        Console.WriteLine($"Subtraction Result: {resultSubtraction}");
        Console.WriteLine($"Multiplication Result: {resultMultiplication}");
        Console.WriteLine($"Division Result: {resultDivision}");
        Console.WriteLine();


        // Prompt user for input
        Console.WriteLine("Challenge 3");
        Console.Write("Enter a new value for integerVariable: ");

        // Read user input and convert it to an integer
        int userInputInt = Convert.ToInt32(Console.ReadLine());

        // Display the user-inputted value
        Console.WriteLine($"You entered: {userInputInt}");
        Console.WriteLine();

        // Test by performing an operation with user input
        int resultWithUserInput = userInputInt + 5;
        Console.WriteLine($"Result of adding 5 to user input: {resultWithUserInput}");
    }
}
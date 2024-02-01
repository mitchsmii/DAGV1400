// challenge 1
using System;
using System.Security.Cryptography;

public class Program {
   // The main function, which calls the two challenges separately
    public static void Main() {
        chal1();
        chal2();
    }
    // begins the function for challenge 1
    public static void chal1() {

        // writes out the prompt to the user
        Console.WriteLine("Enter the current temperature in Celsius: ");

        // asks the user for input and converts it into an integer
        int temp = Convert.ToInt32(Console.ReadLine());

        // checks to see if the input is greater than 30
        if (temp > 30) {

            // if it is, it prints out the following statemt
            Console.WriteLine("Stay hydrated and avoid staying in the sun for too long.");

            // if it is not, it will print out this other statement
        } else {
            Console.WriteLine("Enjoy the pleasants weather!");
        }
    }

    // challenge 2
    
    // begins the function for challenge 2
    public static void chal2() {

        // asks the user the following prompt about the grade on your exam
        Console.WriteLine("Please enter the grade received on your exam:");

        // asks the user for input and converts it into an integer
        int score = Convert.ToInt32(Console.ReadLine());

        // checks to see if the score meets the criteria for an A and prints out a message saying the got an A
        if (score >= 90 && score < 100) {
            Console.WriteLine("You received an A!");

        // checks to see if the score meets the criteria for a B and prints out a message saying the got a B
        } else if (score >= 80 && score < 90) {
            Console.WriteLine("You received a B!");
        // checks to see if the score meets the criteria for a C and prints out a message saying the got a C
        } else if (score >= 70 && score < 80) {
            Console.WriteLine("You received a C!");

        // checks to see if the score meets the criteria for a D and prints out a message saying they got a D
        } else if (score >= 60 && score < 70) {
            Console.WriteLine("You received a D!");

        // checks to see if the score meets the criteria for an F and prints out a message saying they got an F
        } else if (score >= 50 && score < 60) {
            Console.WriteLine("You received a F!");

        }
    }
}





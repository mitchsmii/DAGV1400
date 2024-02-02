// challenge 1
using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

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
        if (temp >= 30) {

            // if it is, it prints out the following statemt
            Console.WriteLine("Stay hydrated and avoid staying in the sun for too long.");

            // if it is not, it will print out this other statement
        } else if (temp < 30 && temp >= 20) {
            Console.WriteLine("Great weather today! Go outside and enjoy the warmth!");

            // checks to see if the weather is between 20 and 10 degrees, and then prints out a statement saying its a little cold
        } else if (temp < 20 && temp >= 10) {
            Console.WriteLine("It's a little cold today, bring a light jacket!");

            // checks to see if the temperature is between 0 and 10 degrees, if it is, then it prints out a statement saying that its very cold
        } else if (temp < 10 && temp >= 0) {
            Console.WriteLine("It's really cold today, bring a big jacket!");

            // checks to see if the temperature is below 0 degrees, and if it is, then 
        } else if (temp < 0) {
            Console.Write("It is ridiculously cold today, do not go outside!");
        }

            // if any other kind of input is entered, then it prints out that the entry is invalid
         else {
            Console.WriteLine("Invalid entry");
        }
    }

    // challenge 2
    
    // begins the function for challenge 2
    public static void chal2() {

        // asks the user the following prompt about the grade on your exam
        Console.WriteLine("Please enter the grade received on your exam:");

        // asks the user for input and converts it into an integer
        int score = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please insert your favorite subject as well!");
        string subject = Console.ReadLine(); 

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
        } else {
            Console.WriteLine("You received a F!");
        }

        // checks to see if the subject input is math
        if (subject.ToLower() == "math") {

            //prints the following statement if it is
            Console.WriteLine("Keep practicing your math equations and algebra!");

        // checks to see if the subject input is math
        } else if (subject.ToLower() == "science") {

            //prints the following statement if it is
            Console.WriteLine("Keep practicing balancing equations and mixing chemicals!");

        // checks to see if the subject input is math
        } else if (subject.ToLower() == "english") {

            //prints the following statement if it is
            Console.WriteLine("Keep studying your grammar and working hard on your essays!");

        // checks to see if the subject input is math
        } else if (subject.ToLower() == "history") {

            //prints the following statement if it is
            Console.WriteLine("Keep studying hard and memorizing those dates!");

        // checks to see if the subject input is math
        } else if (subject.ToLower() == "art") {

            //prints the following statement if it is
            Console.WriteLine("Keep drawing and working on your projects!");
        }

    }
}
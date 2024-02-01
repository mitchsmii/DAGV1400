// challenge 1
using System;
using System.Security.Cryptography;

public class Program {
    public static void Main() {
        chal1();
        chal2();
    }
    public static void chal1() {
        Console.WriteLine("Enter the current temperature in Celsius: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 30) {
            Console.WriteLine("Stay hydrated and avoid staying in the sun for too long.");
        } else {
            Console.WriteLine("Enjoy the pleasants weather!");
        }
    }

    // challenge 2
    public static void chal2() {
        Console.WriteLine("Please enter the grade received on your exam:");
        int score = Convert.ToInt32(Console.ReadLine());
        if (score >= 90 && score < 100) {
            Console.WriteLine("You received an A!");
        } else if (score >= 80 && score < 90) {
            Console.WriteLine("You received a B!");
        } else if (score >= 70 && score < 80) {
            Console.WriteLine("You received a C!");
        } else if (score >= 60 && score < 70) {
            Console.WriteLine("You received a D!");
        } else if (score >= 50 && score < 60) {
            Console.WriteLine("You received a F!");

        }
    }
}





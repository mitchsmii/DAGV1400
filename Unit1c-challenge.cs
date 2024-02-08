using System;

class Program 
{
// The main method which calls both of the challenges
    static void Main() {
        chal1();
        chal2();


// beings challenge 1
    static void chal1() {


        // creates the random integer and stores it as a variable
        Random rdm = new Random();
        int number = rdm.Next(10);

        //creates the answer and count variable
        int input = 0;
        int count = 0;

        //keeps a loop going as long as the input doesn't equal the number)
        while (input != number) {

            // Asks the user for a number between 0 and 10
            Console.WriteLine("Guess a number between 0 and 10");
            input = Convert.ToInt32(Console.ReadLine());

            // verifies if the input is greater than the number
            if (input > number) {
                Console.WriteLine("Too high!");
                count += 1; // increases the count by 1

            // checks to see if the input is less than the number
            } else if (input < number) {
                Console.WriteLine("Too low!");
                count += 1; // increases the count by 1

            // checks to see if the input is the same as the number
            } else if (number == input) {
                count += 1; // increases the count by 1
                Console.WriteLine("Correct!");

                // this outputs the correct grammar if it took the user 1 "try" versus many "tries".
                // also outputs how many tries it took the user to get the correct answer
                if (count == 1) {
                    Console.WriteLine($"This took you {count} try");
                } else {
                    Console.WriteLine($"This took you {count} tries");
                }

            }
        }
    }

    // begins the challenge 2 method
    static void chal2() {
        Console.WriteLine("");

        // Creates an empty array
        string[] foods = new string[3];

        // creates a for loop, that makes the index variable, and as long as that is less than the length of the empty array, it performs the following code, and then increases the index by 1
        for (int i = 0; i < foods.Length; i++) {

            // asks the user for their favorite food
            Console.WriteLine("Enter a favorite food:");

            // puts the input into the foods array with the current index
            foods[i] = Console.ReadLine();
        }
            // prints out each of the foods
        foreach (string food in foods) {
            Console.WriteLine($"I love {food}!"); 
        }
    }
    }
}

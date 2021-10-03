// This is a comment

/*
This is
a comment
but on
multiple lines
*/



// Comments are useful do describe what you are doing and to
// make you code clearer.
// Using too little will make it hard for the teacher or
// someone else in your group to understand what you are doing,
// but using too many will make it hard to read your code and
// is pretty useless. Some people say that a good code doesn't
// need comments, but you actually need to find the right
// balance.



// A namespace is like a folder where you store your code.
// You need to name it after the name of your project.
// Don't worry about that for now.

using System;

namespace Example_Project
{

    // A class is used to create an object. We will come back to
    // it later.
    // Don't worry about that for now.
    public class Bases
    {

        // "Main" is the function/method where the program will
        // begin.
        // Don't worry about the syntax for the methods now, we
        // will see them later.
        public static void Main()
        {



            // Alright let's get things started.
            // First of all, the computer needs to be able to
            // remember things.
            // To do so, we use variables or constants.
            // The computer is able to store a variety of things:
            // numbers (integers, decimals...), text, lists and
            // whatever you teach it!
            var age = 19;
            var name = "Leo";

            // Using the keyword "var" to declare a variable is
            // great but it is better
            // to tell the computer what type of data we those
            // values are.
            int myInteger = 5; // Number with no decimals
            double myDouble = 1.68;
            string myString = "Hello :)"; // Text
            bool myBool = true; // True or false

            // You may also change those values (note: the
            // computer already knows what type they are, you
            // don't need to remind it)
            age = 20;
            myString = "I changed!";

            // You may also define constant values but you won't
            // be able to modify them.
            const double pi = 3.14159265359;

            // Always remember the basic syntax of how to create
            // a variable as this is fundamental:
            // type name = value;



            // Next, we need a way to communicate with the
            // computer. This is done via a "console".
            // Out can show text in the console like this:
            Console.WriteLine("Hello world!"); 

            // And you can also ask input from the user in the
            // console like this:
            Console.Out.WriteLine("What is you name?");
            name = Console.ReadLine();
            Console.Out.WriteLine("Hello " + name + "! Nice to meet you!");
            // Note: the + sign is used to add text together.



            // Obviously, a computer wouldn't work if it couldn't do math.
            // You may perform many operations:
            // Addition with +
            // Subtraction with -
            // Multiplication with *
            // Division with /
            // Modulo with % (remainder of a division)
            // ...
            // Use the Math library if you need operations such as square root or rounding numbers (more on that later)
            int a = 5;
            int b = 7;
            int sum = a + b;
            int mul = a * b;
            Console.Out.WriteLine("5 + 7 = " + sum);
            Console.Out.WriteLine("5 x 7 = " + mul);

            // You may also compare numbers.
            // a == b   a equal b ?
            // a != b   a different than b ?
            // a >= b   a greater or equal b ?
            // a > b    a strictly greater than b ?
            // same with <= and < for less than
            bool greater = a >= b;
            Console.Out.WriteLine("Is 5 greater or equal to 7? : " + greater);



            // Don't forget to close you curly brackets!
        }
    }
}



// This document is a work in progress. More will be added later
// If you need more info, I recommend this website:
// https://www.w3schools.com/cs/index.php
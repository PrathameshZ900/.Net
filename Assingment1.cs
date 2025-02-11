// Q1. find output following code.
// int x = 10;
// if (x = 5)
// Console.WriteLine("True");
// else
// Console.WriteLine("False");

// Ans: x = 5 (Incorrect) → This is an assignment, meaning x would be set to 5, which is not allowed in an if condition.
// x == 5 (Correct) → This is a comparison, checking if x is equal to 5.

// Updated Cde

int x = 10;
if (x == 5)  // Use '==' for comparison
    Console.WriteLine("True");
else
    Console.WriteLine("False");

// Q2. find out the following code output

// int a = 10, b = 20, c = 30;
// if (a > b && a > c)
// Console.WriteLine("A is largest");
// else if (b > a && b > c)
// Console.WriteLine("B is largest");
// else
// Console.WriteLine("C is largest");

// Ans: C is Largest value present here

int a = 10, b = 20, c = 30;

if (a >= b && a >= c)
    Console.WriteLine("A is largest");
else if (b >= a && b >= c)
    Console.WriteLine("B is largest");
else
    Console.WriteLine("C is largest");



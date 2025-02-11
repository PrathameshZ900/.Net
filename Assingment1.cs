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


// Q3. find and correct this code.

// int num = 2;
// switch (num + 1) {
// case 1: Console.Write("One");
// break;
// case 2: Console.Write("Two");
// break;
// case 3: Console.Write("Three");
// case 4: Console.Write("Four");
// break;
// default: Console.Write("Default");
// }

// Ans: it will return an error due to 3 and default case there is not break for this case:

int num = 2;
    switch (num + 1)  // num + 1 = 3
    {
        case 1: 
            Console.Write("One");
            break;
        case 2: 
            Console.Write("Two");
            break;
        case 3: 
            Console.Write("Three");
            break;  // Added break to prevent fall-through
        case 4: 
            Console.Write("Four");
            break;
        default: 
            Console.Write("Default");
            break;
    }

// Q4. Guess the output of the following code.

int x = 0;
if (x)
  Console.WriteLine("Hello");
else
  Console.WriteLine("World");


// Ans: out put is "World" 


// Q5. Guess the output of the following code.

bool isTrue = false;
if (isTrue == true)
  Console.WriteLine("Yes");
else
  Console.WriteLine("No");

// Ans: out put is error because the camprasion == use this  and after update the output is "No".


// Q6. Guess the output of the following code.


int x = 5, y = 10;
if (x > 0)
if (y < 10)
Console.WriteLine("A");
else
Console.WriteLine("B");
else
Console.WriteLine("C");



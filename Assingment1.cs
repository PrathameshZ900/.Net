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


// Q7. find the out put

int a = 5;
if (a > 0)
  if (a < 10)
    Console.WriteLine("X");
  else if (a > 2)
    Console.WriteLine("Y");
else
  Console.WriteLine("Z");

// Ans: out put would be "X"

// Q8. find out the out put

int x = 5, y = 10;
if (x++ > 5 && y++ < 10)
  Console.WriteLine(x,y);
else
  Console.WriteLine(x,y);

// Ans: out put would be (6,10)


// Q9. find out the out put.

double x = 0.1 + 0.2;
if (x == 0.3)
  Console.WriteLine("Equal");
else 
  Console.WriteLine("Not Equal");

// Ans : "Not Equal"

// Q10. find out the out put.

decimal x = 0.1m + 0.2m;
if (x == 0.3m)
  Console.WriteLine("Equal");

// Ans : "Equal"

// Q11. find out the out put.

for (int i = 1; i <= 5; i++)
{
Console.Write(i + " ");
}

// Ans: 1 2 3 4 5;


// Q12. find out the out put.

for (int i = 5; i >= 1; i--)
{
Console.Write(i + " ");
}

// Ans: 5 4 3 2 1;

// Q13. find out the out put.

(int i = 1; i <= 5; i++)
{
if (i == 3)
continue;
Console.Write(i + " ");
}


// Ans: "1 2 4 5";

// Q14. find out the out put.

for (int i = 1; i <= 5; i++)
{
if (i == 3)
break;
Console.Write(i + " ");
}

// Ans: "1 2"

// Q15. find out the out put.

int i = 1;
while (i <= 3)
{
Console.Write(i + " ");
i++;
}

// Ans: "1 2 3";

// Q16. find out the out put. 

int i = 1;
while (i > 0)
{
Console.Write(i + " ");
if (i == 3) break;
i++;
}

// Ans: "1 2 3";

// Q17. find out the out put.

int i = 5;
do
{
Console.Write(i + " ");
} while (i < 3);

// Ans: return an error because the their is no increment for i++ other else it will print "5" fail the condition;

// Q18. find out the output. 

for (int i = 1; i <= 3; i++)
{
for (int j = 1; j <= 2; j++)
{
Console.Write(i + "" + j + " ");
}
}


// Ans: "11 12 21 22 31 32";

// Q19. find the out put.

for (int i = 2; i <= 10; i += 2)
{
Console.Write(i + " ");
}


// Ans: "2 4 6 8 10";

// Q20. find out the out put.


int i = 1;
while (i <= 10)
{
Console.Write(i + " ");
i += 2;
}

// Ans: "1 3 5 7 9";


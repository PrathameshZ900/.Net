// Q7. What is an infinite loop? Provide examples using for, while, and do-while.

// Ans: Infinite loop runs Infinitely. mens its never stop or terminate. due to is passing his conditionh.

// using for loop 

for (int i = 0; i >= 0; i++) {
  Console.WriteLine("This will run forever");
}

// using while loop 



while( true ){
     Console.WriteLine("This will run forever");
}


// using do while 


do
{
    
    Console.WriteLine("This will run forever");
} while (true);




// Q9. How does the break statement work inside loops?

// In C#, the break statement is used to exit a loop immediately, stopping further iterations.

// Q10. What is the role of the continue statement in loops?

// In C#, the continue statement is used within loops to skip the current iteration and proceed directly to the next one.
//  When the continue statement is encountered, the remaining code inside the loop for that iteration is bypassed, 
// and the loop moves on to its next cycle. 

// Q11. How can you exit multiple nested loops at once?
// return , flag var, goto.

// Q12. What is the difference between break and return inside a loop?

// In C#, the break statement exits the current loop, while the return statement exits the entire method. Use break to stop looping and continue with the code that follows the loop; 
// use return to end method execution and return control to the calling context.

// Q13. How do you iterate through an array using loops?
int[] numbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// Q14. Write a C# program to find the largest and smallest number in an array using loops.

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 12, 5, 8, 130, 22 };

        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            else if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine($"The smallest number is: {min}");
        Console.WriteLine($"The largest number is: {max}");
    }
}


// Q15. Can a for loop run indefinitely? If yes, how?


for (;;)
{
    // Code to execute repeatedly
}

// Q16. How do you implement a loop using recursion instead of traditional looping constructs?


using System;

class Program
{
    static int Sum(int[] numbers, int index)
    {
        if (index >= numbers.Length)
            return 0;
        return numbers[index] + Sum(numbers, index + 1);
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int result = Sum(numbers, 0);
        Console.WriteLine($"The sum is: {result}");
    }
}



// Q17. What is the impact of using goto inside loops? Is it recommended? Explain with an example.

using System;

class Program
{
    static void Main()
    {
        bool found = false;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == 3 && j == 3)
                {
                    found = true;
                    goto ExitLoops;
                }
            }
        }

    ExitLoops:
        if (found)
            Console.WriteLine("Condition met, exited loops.");
        else
            Console.WriteLine("Condition not met.");
    }
}



// Q18. How does a foreach loop work internally in C#?

// In C#, the foreach loop is a convenient way to iterate over collections like arrays or lists. It simplifies the process by automatically
//  handling the iteration, so you don't need to manage the index or the collection's length manually.

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}



// Q19. Can a foreach loop be replaced with a for loop? If yes, in what cases?

int[] numbers = { 10, 20, 30, 40, 50 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Index {i}: {numbers[i]}");
}


// Q20. How do you optimize performance in loops when working with large datasets?


























// Q1. What are the different types of loops in C#?

// Ans: There are four types of loop in C#.
// 1. for Loop.
// 2. foreach Loop.
// 3. while Loop.
// 4. do While Loop.

// Q2. Explain the syntax and working of the for loop in C#.

// // Ans:  for loop is useful when the number of iterations is known.

//  It consists of initialization, condition, and iteration expressions.

// for (initialization; condition; iteration)
// {
//     // Code to be executed
// }

int num = 5;

for(int i = 0; i < num; i++){
    Console.WriteLine(i);
}


// Q3. How does a while loop work?
// Ans: 
// while (condition)
// {
//     // Code to be executed
// }

int j = 0; // inicilaztion

while( j < 10){//conditiion
    Console.WriteLine(j); // output
    j++;  // ittretation
}


// Q4. What is the difference between a while loop and a do-while loop?


// Ans: 

// In C#, the while loop and do-while loop both execute a block of code repeatedly based on a condition, 
// but they differ in how they check the condition. The while loop checks the condition before execution, 
// meaning if the condition is false initially, the loop may not execute at all. In contrast, the do-while 
// loop checks the condition after execution, ensuring that the loop executes at least once, even if the condition
//  is false.

//  while Loop: while(condition) { // Code }

//  do while loop : do { // Code } while(condition);


// Q5. What happens if the loop condition in a while loop is initially false?
// Ans: If the loop condition in a while loop is initially false, the loop will not 
// execute even once because the condition is checked before the loop body runs.

// Q6. How do you use a foreach loop in C#?

//Ans: 

// foreach (var item in collection)
// {
//     // Code to execute for each item
// }

        int[] numbers = { 1, 2, 3, 4, 5 };

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

// Q7. Can we modify elements inside a foreach loop? Why or why not?

// Ans:  No, you cannot modify elements directly inside a foreach loop in C# because foreach is designed for read-only iteration.

// foreach uses an enumerator internally, which does not allow modifying the collection elements directly.
// It prevents unintended side effects by ensuring elements are not changed during iteration.
// If modification were allowed, it could lead to unexpected behavior or runtime errors, especially for collections like List<T>.











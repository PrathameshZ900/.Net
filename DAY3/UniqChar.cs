// 4. Find First Non-Repeating Character in a String
// Given a string, find the first non-repeating character.
// Signature: public static char FirstUniqueChar(string str)
// Example Input: "swiss"
// Output: 'w'

using System;
using System.Collections.Generic;

char FirstUniqueChar(string str) {
    Dictionary<char, int> charCount = new Dictionary<char, int>();


    foreach (char c in str) {
        if (charCount.ContainsKey(c))
            charCount[c]++;
        else
            charCount[c] = 1;
    }

    foreach (char c in str) {
        if (charCount[c] == 1)
            return c;
    }

    return '\0'; 
}


string input = "swiss";
Console.WriteLine("First Unique Character: " + FirstUniqueChar(input));

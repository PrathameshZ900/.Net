// 19. Find the Longest Palindromic Substring
// Find the longest palindrome in a string.
// Signature: public static string LongestPalindrome(string s)
// Example Input: "babad"
// Output: "bab"

using System;

string LongestPalindrome(string s) {
    if (s.Length < 2) return s;
    
    int start = 0, maxLen = 0;

    void Expand(int l, int r) {
        while (l >= 0 && r < s.Length && s[l] == s[r]) {
            l--; r++;
        }
        if (r - l - 1 > maxLen) {
            start = l + 1;
            maxLen = r - l - 1;
        }
    }

    for (int i = 0; i < s.Length; i++) {
        Expand(i, i);
        Expand(i, i + 1);
    }

    return s.Substring(start, maxLen);
}

string s = "babad";
Console.WriteLine(LongestPalindrome(s));

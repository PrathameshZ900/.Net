// 16. Find All Anagrams of a String in Another String
// Find all start indices of t's anagrams in s.
// Signature: public static List<int> FindAnagrams(string s, string t)
// Example Input: "cbaebabacd", "abc"
// Output: [0, 6]


using System;
using System.Collections.Generic;

List<int> FindAnagrams(string s, string t) {
    var res = new List<int>();
    if (t.Length > s.Length) return res;

    var tCount = new int[26];
    var sCount = new int[26];

    foreach (char c in t) tCount[c - 'a']++;

    for (int i = 0; i < s.Length; i++) {
        sCount[s[i] - 'a']++;
        if (i >= t.Length) sCount[s[i - t.Length] - 'a']--;

        if (EqualArrays(sCount, tCount)) res.Add(i - t.Length + 1);
    }
    return res;
}

bool EqualArrays(int[] a, int[] b) {
    for (int i = 0; i < 26; i++) if (a[i] != b[i]) return false;
    return true;
}

string s = "cbaebabacd", t = "abc";
Console.WriteLine(string.Join(", ", FindAnagrams(s, t)));

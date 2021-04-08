using System;

class Solution
{
    // You are given a string containing characters A and B only.
    // Your task is to change it into a string such that there are
    // no matching adjacent characters. To do this, you are allowed
    // to delete zero or more characters in the string.

    // Your task is to find the minimum number of required deletions.

    // Complete the alternatingCharacters function below.
    static int alternatingCharacters(string s)
    {
        int deletions = 0;
        char last = ' ';

        foreach(char c in s)
        {
            if (c == last)
                deletions++;
            else
                last = c;
        }

        return deletions;
    }

    static void Main(string[] args)
    {
        string[] testcases = new string[]
        {
            "AAAA",     // 3
            "BBBBB",    // 4
            "ABABABAB", // 0
            "BABABA",   // 0
            "AAABBB"    // 4
        };

        foreach (string testcase in testcases)
        {
            int result = alternatingCharacters(testcase);

            Console.WriteLine(result);
        }
    }
}

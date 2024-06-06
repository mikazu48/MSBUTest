using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Please input number : ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input k value (gap) : ");
        int replacement = int.Parse(Console.ReadLine());
        int highestPalindrome = FindHighestPalindrome(input, replacement);
        Console.WriteLine("Highest Palindrome: " + highestPalindrome);
    }
    
    
    public static int FindHighestPalindrome(int input, int replacement)
    {
        string inputStr = input.ToString();
        int length = inputStr.Length;

        if (IsPalindrome(input))
            return input;

        int mid = length / 2;

        string left = inputStr.Substring(0, mid);
        string right = inputStr.Substring(length - mid);

        string reverseLeft = ReverseString(left);

        if (string.Compare(left, reverseLeft) >= 0)
        {
            // Increment the left part
            left = Increment(left, replacement);

            if (left.Length > mid)
            {
                if (mid * 2 == length)
                {
                    char middleDigit = inputStr[mid];
                    int digit = int.Parse(middleDigit.ToString()) + 1;
                    if (digit > 9)
                    {
                        inputStr = inputStr.Remove(mid, 1).Insert(mid, "0");
                        return FindHighestPalindrome(int.Parse(inputStr), replacement);
                    }
                    else
                    {
                        inputStr = inputStr.Remove(mid, 1).Insert(mid, digit.ToString());
                    }
                }
                return FindHighestPalindrome(int.Parse(inputStr), replacement);
            }
        }

        string palindrome = left + reverseLeft;
        return int.Parse(palindrome);
    }

    public static bool IsPalindrome(int number)
    {
        string str = number.ToString();
        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    public static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static string Increment(string str, int replacement)
    {
        int number = int.Parse(str);
        number += replacement;
        return number.ToString();
    }

}
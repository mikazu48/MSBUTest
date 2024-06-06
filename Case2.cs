using System;

public class HelloWorld
{
    public static bool AreBracketsBalanced(string input)
    {
        char[] stack = new char[input.Length];
        int top = -1;
       
        foreach (char bracket in input)
        {
            if (bracket == '(' || bracket == '[' || bracket == '{')
            {
                stack[++top] = bracket;
            }
            else if (bracket == ')' || bracket == ']' || bracket == '}')
            {
                if (top == -1 || !AreMatchingBrackets(stack[top--], bracket))
                {
                    return false;
                }
            }
        }

        return top == -1;
    }

    public static bool AreMatchingBrackets(char opening, char closing)
    {
        return (opening == '(' && closing == ')') ||
               (opening == '[' && closing == ']') ||
               (opening == '{' && closing == '}');
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Input Brackets : ");
        string input = Console.ReadLine();
        bool balanced = AreBracketsBalanced(input);
        if (balanced)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
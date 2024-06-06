# Case 2 : Explanation

#### Untuk penyelesaian mencari Balanced Brackets, kita harus membuat fungsi loop/iterasi berdasarkan string yg dinput.

```
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
```

Apabila terdapat bracket yg tidak ter-struktur dengan kondisi loop, maka akan mengembalikan nilai **false**.

Loop, juga mengecek kondisi variable dari **opening** dan **closing** yang dilempar ke argument di fungsi :

```


    public static bool AreMatchingBrackets(char opening, char closing)
    {
        return (opening == '(' && closing == ')') ||
               (opening == '[' && closing == ']') ||
               (opening == '{' && closing == '}');
    }
```
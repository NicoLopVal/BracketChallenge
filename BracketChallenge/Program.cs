Stack<char> stack = new Stack<char>();

string testString = "([{fsdfsdfhfghfghhft}](999))";

Console.WriteLine(CheckBrackets(testString));


bool CheckBrackets(string text)
{
    bool bracketsOk = true;
    foreach (char c in testString)
    {
        if (c == '(' || c == '[' || c == '{')
            stack.Push(c);
        else if (stack.Count > 0 && ((c == ')' && stack.Peek() == '(') ||
            (c == ']' && stack.Peek() == '[') ||
            (c == '}' && stack.Peek() == '{')))
        {
            stack.Pop();
        }
        else if (stack.Count > 0 && ((c == ')' && stack.Peek() != '(') ||
            (c == ']' && stack.Peek() != '[') ||
            (c == '}' && stack.Peek() != '{')))
        {
            bracketsOk = false;
            break;
        }
        else if (stack.Count == 0 && (c == ')' || c == ']' || c == '}'))
        {
            bracketsOk = false;
            break;
        }
    }

    if (stack.Count > 0)
        bracketsOk = false;

    return bracketsOk;
}
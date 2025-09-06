namespace NeetCode.Easy.Stack
{
    public class Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(c);
                else
                {
                    if (stack.Count > 0)
                    {
                        char top = stack.Peek();

                        if ((c == ')' && top == '(') || c == '}' && top == '{' || c == ']' && top == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return stack.Count == 0;


        }
    }
}

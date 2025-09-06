namespace NeetCode.Medium.Stack
{
    public class Evaluate_Reverse_Polish_Notation
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            foreach (var token in tokens)
            {
                if (token == "+")
                {
                    stack.Push(stack.Pop() + stack.Pop());
                }
                else if (token == "-")
                {
                    int b = stack.Pop();
                    int a = stack.Pop();

                    stack.Push(a - b);
                }
                else if (token == "*")
                {
                    stack.Push(stack.Pop() * stack.Pop());
                }
                else if (token == "/")
                {
                    int b = stack.Pop();
                    int a = stack.Pop();

                    stack.Push(a / b);
                }
                else
                {
                    stack.Push(Convert.ToInt32(token));
                }
            }
            return stack.Pop();
        }
    }
}
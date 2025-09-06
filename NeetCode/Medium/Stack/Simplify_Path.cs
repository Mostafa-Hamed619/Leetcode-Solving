using System.Text;

namespace NeetCode.Medium.Stack
{
    public class Simplify_Path
    {
        public string SimplifyPath(string path)
        {
            Stack<string> stack = new Stack<string>();

            string[] Directories = path.Split('/');

            foreach (var directory in Directories)
            {
                if (directory.Equals(".") || string.IsNullOrEmpty(directory)) continue;

                if (directory.Equals(".."))
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else
                {
                    stack.Push(directory);
                }
            }
            return ConvertToStringPath(stack);

        }

        private string ConvertToStringPath(Stack<string> stack)
        {
            StringBuilder result = new StringBuilder();

            foreach (var directory in stack.Reverse())
            {
                result.Append("/").Append(directory);
            }
            return result.Length > 0 ? result.ToString() : "/";
        }
    }
}

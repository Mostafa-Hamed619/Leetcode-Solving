namespace NeetCode.Medium.Stack
{
    public class Asteroid_Collision_735
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new();

            foreach (var i in asteroids)
            {
                int Current = i;
                while (stack.Count() > 0 && (stack.Peek() > 0 && i < 0))
                {
                    bool DestroySmallerCondition = (stack.Peek() < Math.Abs(i));
                    bool DestroyBothCondition = (stack.Peek() == Math.Abs(i));

                    if (DestroySmallerCondition)
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (DestroyBothCondition)
                    {
                        stack.Pop();
                        Current = 0;
                        break;
                    }
                    else
                    {
                        Current = 0;
                        break;
                    }
                }
                if (Current != 0)
                {
                    stack.Push(Current);
                }
            }

            return stack.Reverse().ToArray();
        }
    }
}

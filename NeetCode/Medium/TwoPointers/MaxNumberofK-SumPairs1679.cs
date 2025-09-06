namespace NeetCode.Medium.TwoPointers
{
    public class MaxNumberofK_SumPairs1679
    {
        public int MaxOperations(int[] nums, int k)
        {
            Dictionary<int, int> Dic = new();
            int Operate = 0;
            AddToDic(nums, Dic);

            for (int i = 0; i < nums.Length; i++)
            {
                int Complement = k - nums[i];

                if (Dic[nums[i]] > 0)
                {
                    if (Dic.ContainsKey(Complement) && Dic[Complement] > 0)
                    {
                        if (nums[i] == Complement && Dic[nums[i]] < 2)
                            continue;
                        Dic[nums[i]] -= 1;
                        Dic[Complement] -= 1;
                        Operate += 1;
                    }
                }

            }
            return Operate;
        }

        private void AddToDic(int[] nums, Dictionary<int, int> Dic)
        {
            for (int i = 0; i < nums.Length; i++)
            {

                if (Dic.ContainsKey(nums[i]))
                {
                    Dic[nums[i]] += 1;
                }
                else
                {
                    Dic[nums[i]] = 1;
                }
            }
        }
    }
}

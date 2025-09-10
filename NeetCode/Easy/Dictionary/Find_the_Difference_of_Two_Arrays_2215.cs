namespace NeetCode.Easy.Dictionary
{
    public class Find_the_Difference_of_Two_Arrays_2215
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            IList<IList<int>> Result = new List<IList<int>>();
            IList<int> Diff1 = new List<int>();
            IList<int> Diff2 = new List<int>();

            HashSet<int> map1 = new();
            HashSet<int> map2 = new();

            foreach (var i in nums1)
            {
                if (map1.Contains(i))
                    continue;
                map1.Add(i);
            }
            foreach (var i in nums2)
            {
                if (map2.Contains(i))
                    continue;
                map2.Add(i);
            }

            foreach (var i in map1)
            {
                if (map2.Contains(i))
                    continue;
                Diff1.Add(i);
            }

            foreach (var i in map2)
            {
                if (map1.Contains(i))
                    continue;
                Diff2.Add(i);
            }

            Result.Add(Diff1);
            Result.Add(Diff2);
            return Result;
        }
    }
}

namespace NeetCode.Easy.Dictionary
{
    public class Find_the_Difference_of_Two_Arrays_2215
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {

            IList<int> Diff1 = new List<int>();
            IList<int> Diff2 = new List<int>();

            HashSet<int> map1 = new(nums1);
            HashSet<int> map2 = new(nums2);



            foreach (var i in map1)
            {
                if (!map2.Contains(i))
                    Diff1.Add(i);
            }

            foreach (var i in map2)
            {
                if (!map1.Contains(i))
                    Diff2.Add(i);
            }

            return new List<IList<int>> { Diff1, Diff2 };
        }
    }
}

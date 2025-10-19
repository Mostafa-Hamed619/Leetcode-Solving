namespace NeetCode.Easy.BinarySearch
{
    public class Search_Insert_Postion
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0; int right = nums.Length - 1;
            int Mid = 0;
            while (left <= right)
            {
                Mid = left + (right - left) / 2;
                if (nums[Mid] == target)
                    return Mid;
                if (nums[Mid] > target)
                    right = Mid - 1;
                if (nums[Mid] < target)
                    left = Mid + 1;
            }

            return left;
        }
    }
}

public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> myList1 = new List<int>(nums);
        List<int>nums_copy=new List<int>();
        foreach(int i  in myList1)
        {
            if(!nums_copy.Contains(i))
            {
                nums_copy.Add(i);
            }
        }
        if(nums_copy.Count!=myList1.Count)
        {
            return true;
        }
        return false;
    }
}
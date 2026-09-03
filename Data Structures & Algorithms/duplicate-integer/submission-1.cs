public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int>dict=new Dictionary<int,int>();
        foreach(int i in nums)
        {
            if(dict.ContainsKey(i))
            {
                dict[i]+=1;
            }
            else{
                dict[i]=1;
            }
        }
        foreach(int i in dict.Values)
        {
            if(i>1)
            {
                return true;
            }
        }
        return false;
    }
}
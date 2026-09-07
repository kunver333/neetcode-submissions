public class Solution {
    public bool IsAnagram(string s1, string s2) {
        if(s1.Length!=s2.Length)
				return false;
			Dictionary<char,int>dict=new Dictionary<char,int>();
			foreach(char ch in s1)
			{
				if(dict.ContainsKey(ch))
				{
					dict[ch]++;
				}
				else {
					dict[ch]=1;
				}
			}
			foreach(char ch in s2)
			{
				if(!dict.ContainsKey(ch))
					return false;
				dict[ch]--;
                if(dict[ch]<0) 
                    return false;
			}
			return true;
    }
}

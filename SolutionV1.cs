public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var commonPrefix = "";
        for(int i = 0; i < strs[0].Length; i++)
        {
            var currentChar = strs[0][i];
            foreach(var str in strs)
                if(i >= str.Length || str[i] != currentChar)
                    return commonPrefix;
            commonPrefix += currentChar;
        }
        return commonPrefix;
    }
}

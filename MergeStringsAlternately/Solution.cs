public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var pointerLeft = 0;
        var pointerRight = Math.Max(word1.Length, word2.Length);
        var result = "";
        while(pointerLeft < pointerRight){
            result += word1.Length > pointerLeft? word1[pointerLeft].ToString() : "";
            result += word2.Length > pointerLeft?word2[pointerLeft].ToString() : "";
            pointerLeft++;
        }

        return result;       
    }
}
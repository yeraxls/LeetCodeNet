using System.Text;

public class Vowels
{
    private readonly string vowelsLetters = "aeiou";
    public string ReverseVowels(string s)
    {
        StringBuilder st = new StringBuilder();
        StringBuilder st1 = new StringBuilder();

        int i = 0, j = s.Length - 1;
        while (i < j)
        {
            if (!((s[i] == 'a') || (s[i] == 'e') || (s[i] == 'i') || (s[i] == 'o') || (s[i] == 'u')
                || (s[i] == 'A') || (s[i] == 'E') || (s[i] == 'I') || (s[i] == 'O') || (s[i] == 'U')))
            {
                st.Append(s[i]);
                i++;
                continue;
            }

            if (!((s[j] == 'a') || (s[j] == 'e') || (s[j] == 'i') || (s[j] == 'o') || (s[j] == 'u')
                ||
                (s[j] == 'A') || (s[j] == 'E') || (s[j] == 'I') || (s[j] == 'O') || (s[j] == 'U')))
            {
                st1.Append(s[j]);
                j--;
                continue;
            }

            if ((s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' ||
                s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U') &&
                    (s[j] == 'a' || s[j] == 'e' || s[j] == 'i' || s[j] == 'o' || s[j] == 'u' ||
                    s[j] == 'A' || s[j] == 'E' || s[j] == 'I' || s[j] == 'O' || s[j] == 'U'))
            {
                st.Append(s[j]);
                st1.Append(s[i]);
                i++;
                j--;
            }
        }

        if (i == j)
        {
            st.Append(s[i]);
        }

        char[] arr = st1.ToString().ToCharArray();
        Array.Reverse(arr);

        return st.ToString() + new string(arr);
    }
}
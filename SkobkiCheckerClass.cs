namespace ClassWork3.SkobkiCheckerClass
{
    public class SkobkiChecker
    {
        public static bool IsBalanced(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }

            Stack<char> bracketStack = new Stack<char>();

            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

            foreach (char c in input)
            {
                if (bracketPairs.ContainsKey(c))
                {
                    bracketStack.Push(c);
                }
                else if (bracketPairs.ContainsValue(c))
                {
                    if (bracketStack.Count == 0 || bracketPairs[bracketStack.Pop()] != c)
                    {
                        return false;
                    }
                }
            }

            return bracketStack.Count == 0;
        }
    }
}

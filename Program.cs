public static class StringExtensions
    {
        public static bool IsValidBrackets(this string str)
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

            Stack<char> openBrackets = new Stack<char>();

            foreach (char c in str)
            {
                if (bracketPairs.ContainsKey(c))
                {
                    openBrackets.Push(c);
                }
                else if (bracketPairs.ContainsValue(c))
                {
                    if (openBrackets.Count == 0)
                        return false;

                    char lastOpenBracket = openBrackets.Pop();
                    if (bracketPairs[lastOpenBracket] != c)
                        return false;
                }
            }

            return openBrackets.Count == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] testCases = new string[]
            {
            "{}[]",
            "(())",
            "[{}]",
            "[}",
            "[[{]}]"
            };

            foreach (string testCase in testCases)
            {
                Console.WriteLine($"Рядок '{testCase}' є валідним: {testCase.IsValidBrackets()}");
            }
        }
    }
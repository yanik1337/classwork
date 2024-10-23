namespace ClassWork3.ElementFinderClass
{
    public class ElementFinder
    {
        public static int[] Find(int[] array)
        {
            int[] result = new int[array.Length];
            Stack<int> stack = new Stack<int>();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && array[stack.Peek()] <= array[i])
                {
                    stack.Pop();
                }

                if (stack.Count > 0)
                {
                    result[i] = array[stack.Peek()];
                }
                else
                {
                    result[i] = 1;
                }

                stack.Push(i);
            }

            return result;
        }
    }
}

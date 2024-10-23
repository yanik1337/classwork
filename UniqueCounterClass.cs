namespace ClassWork3.UniqueCounterClass
{
    public class UniqueCounter
    {
        public static int CountUnique(List<int> numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

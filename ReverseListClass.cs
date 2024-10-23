namespace ClassWork3.ReverseListClass
{
    public class ReverseList
    {
        public static void Reverse(List<int> list)
        {
            if (list == null || list.Count <= 1)
            {
                return;
            }

            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                int temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
    }
}

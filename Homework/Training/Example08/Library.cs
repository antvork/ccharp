public static class Library
{
    public static int GetPositiveResult(int[] array1)
    {
        int result = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] > 0)
            {
                result = result + array1[i];
            }
        }
        return result;
    }
    public static int GetNegativeResult(int[] array1)
    {
        int result = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] < 0)
            {
                result = result + array1[i];
            }
        }
        return result;
    }
}
using System.Collections;

public static class MathOperationsOnCollections
{
    public static void Reverse(ArrayList? collection)
    {
        if (collection is not null && collection.Count > 0)
        {
            int left = 0;
            int right = collection.Count - 1;
            while (left < right)
            {
                var temp = collection[left];
                collection[left] = collection[right];
                collection[right] = temp;

                left++;
                right--;
            }
        }
        else
            throw new ArgumentException("The ArrayList Cannot Null Or Empty");
    }
    public static void Print(ArrayList collection)
    {
        if (collection is not null && collection.Count > 0)
        {
            for (int i = 0; i < collection.Count; i++)
                Console.Write($"{collection[i]} ");
        }
        else
            throw new ArgumentException("The ArrayList Cannot Null Or Empty");
    }
    public static void Print(List<int> collection)
    {
        if (collection is not null && collection.Count > 0)
        {
            for (int i = 0; i < collection.Count; i++)
                Console.Write($"{collection[i]} ");
        }
        else
            throw new ArgumentException("The ArrayList Cannot Null Or Empty");
    }
    public static List<int> FindEvenNumsAndReturn(List<int>? list, out List<int> output)
    {
        if (list is not null && list?.Count > 0)
        {
            output = new List<int>();
            for (int i = 0; i < list?.Count; i++)
                if (list[i] % 2 == 0)
                    output.Add(list[i]);
            return output;
        }
        else
            throw new ArgumentException("The ArrayList Cannot Null Or Empty");
    }
}
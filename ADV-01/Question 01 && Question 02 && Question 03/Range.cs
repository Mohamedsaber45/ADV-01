using System.Collections;
public class Range<T>  where T : IComparable<T>
{
    public T MinimumValue { get; set; }

    public T MaximumValue { get; set; }

    public Range(T minimum,T maximum)
    {
        if (minimum.CompareTo(maximum) > 0)
        {
            throw new ArgumentException("Minimum Value Cannot be greater than Maximum Value.");
        }
        MinimumValue = minimum;
        MaximumValue = maximum;
    }

    public bool IsInRange(T Value)
    {
        return (Value.CompareTo(MinimumValue) >=0) && (Value.CompareTo(MaximumValue) <= 0);
    }

    public dynamic Length()
    {
        if(typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(decimal) || typeof(T) == typeof(decimal))
            return  ((dynamic)MaximumValue) - ((dynamic)MinimumValue);
        throw new InvalidOperationException("Length Is Not Supported For The Given Type!!");
    }

    public void Reverse(ArrayList? collection)
    {
        if(collection is not null && collection.Count>0)
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
    public void Print(ArrayList collection)
    {
        if (collection is not null && collection.Count >0)
        {
            for (int i = 0; i < collection.Count; i++)
                Console.Write($"{collection[i]} ");
        }
        else
            throw new ArgumentException("The ArrayList Cannot Null Or Empty");
    }
    public void Print(List<int> collection)
    {
        if(collection is not null && collection.Count > 0)
        {
            for (int i = 0; i < collection.Count; i++)
                Console.Write($"{collection[i]} ");
        }
        else
            throw new ArgumentException("The ArrayList Cannot Null Or Empty");
    }

    public List<int> FindEvenNumsAndReturn(List<int>? list, out List<int> output)
    {
        if(list is not null && list?.Count > 0)
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
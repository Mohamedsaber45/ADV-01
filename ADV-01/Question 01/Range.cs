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
}
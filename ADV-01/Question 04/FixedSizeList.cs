public class FixedSizeList<T>
{
    private T[] _items;
    private int _currentSize = 0;

    public FixedSizeList(int FixedCapacity)
    {
        if (FixedCapacity <= 0)
            throw new ArgumentException("Capacity Must Be Greater Then Zero!!");

        _items = new T[FixedCapacity];
    }

    public void Add(T item)
    {
        if (_currentSize >= _items.Length)
            throw new InvalidOperationException("Cannot Add Item: The List Is Full!!");

        _items[_currentSize] = item;
        _currentSize++;
    }

    public T Get(int index)
    {
        if(index >= _items.Length || index < 0)
            throw new InvalidOperationException("Index Cannot Less Then Zero or Cannot Exeeds The Length Of List!!");
        return _items[index];
    }
}

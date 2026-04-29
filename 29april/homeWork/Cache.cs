public static class Cache<T>
{
    private static List<T> items = new List<T>();

    public static void Add(T item)
    {
        items.Add(item);
    }

    public static T Get(int index)
    {
        return items[index];
    }

    public static void Remove(int index)
    {
        items.RemoveAt(index);
    }
}

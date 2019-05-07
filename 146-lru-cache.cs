public class LRUCache
{
    private int lruCount = 0;
    private readonly int capacity;
    private Dictionary<int, LruWrapper> cache; // <key, lru factor / wrapper>

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        cache = new Dictionary<int, LruWrapper>();
    }

    public int Get(int key)
    {
        if (cache.ContainsKey(key))
        {
            // increment LRU:
            lruCount++;
            cache[key].Lru = lruCount;

            // return:
            return cache[key].Value;
        }
        return -1;
    }

    public void Put(int key, int value)
    {

        // increment lru:
        lruCount++;

        // set, accounting for preexisting keys:
        if (cache.ContainsKey(key))
        {
            cache[key] = new LruWrapper
            {
                Value = value,
                Lru = lruCount
            };
        }
        else
        {
            cache.Add(key, new LruWrapper
            {
                Value = value,
                Lru = lruCount
            });
        }

        // invalidate, if applicable:
        if (cache.Count > capacity)
        {
            // find lowest LRU:
            int lowKey = 0;
            int lowLru = Int32.MaxValue;
            foreach (int cacheKey in cache.Keys)
            {
                var record = cache[cacheKey];
                if (record.Lru < lowLru)
                {
                    lowLru = record.Lru;
                    lowKey = cacheKey;
                }
            }
            cache.Remove(lowKey);
        }
    }

    public class LruWrapper
    {
        public int Value { get; set; }

        public int Lru { get; set; }
    }

}
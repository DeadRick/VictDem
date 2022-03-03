using System.Collections.Concurrent;

class Program
{

    private const int RUNS = 1_000;

    //static readonly Dictionary<int, int> dictionary =
    //            new Dictionary<int, int>();

    static readonly ConcurrentDictionary<int, int> dictionary = 
        new ConcurrentDictionary<int, int>();


    static void AddOrUpdate()
    {
        for (var i = 0; i < RUNS; ++i)
        {
            if (dictionary.ContainsKey(i))
            {
                dictionary[i] = dictionary[i] + 1;
                Console.WriteLine($"{i} was updated to {dictionary[i]}");
            }
            else
            {
                dictionary.TryAdd(i, i);
                Console.WriteLine($"{i} was added");
            }
        }
    }


    static void Main(string[] args)
    {
        Task t = Task.WhenAll(
             Task.Run(() => AddOrUpdate()),
               Task.Run(() => AddOrUpdate()),
               Task.Run(() => AddOrUpdate()),
               Task.Run(() => AddOrUpdate()),
               Task.Run(() => AddOrUpdate()), 
               Task.Run(() => AddOrUpdate()),
               Task.Run(() => AddOrUpdate()), 
               Task.Run(() => AddOrUpdate())
               ); ;

        t.Wait();

        foreach (var item in dictionary)
        {
            Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
        }
        Console.WriteLine($"Total number of elements: {dictionary.Count}");

    }
}


namespace project1FooBar
{
public class FooBar
{
    public int Jumlah { get; set; }
    private Dictionary<int, string> dictionary;

    public FooBar(int n)
    {
        Jumlah = n;
        dictionary = new Dictionary<int, string>()
        {
            { 3, "foo" },
            { 5, "bar" },
        };
    }

     public Dictionary<int, string> GetDictionary()
        {
            return dictionary;
        }

    public string Output()
    {
        string result = "";
        for (int i = 1; i <= Jumlah; i++)
        {
            string output = "";
            foreach (var x in dictionary)
            {
                if (i % x.Key == 0)
                {
                    output += x.Value;
                }
            }

            if (string.IsNullOrEmpty(output))
            {
                output = i.ToString();
            }

            result += output;

            if (i < Jumlah)
            {
                result += ", ";
            }
        }
        return result;
    }

     public static string Read(Dictionary<int, string> dictionary)
    {
        string data = "";
        foreach (var x in dictionary)
        {
            data += $"Key: {x.Key}, Value: {x.Value}\n";
        }
        return data;
    }

    public void Add(int key, string value)
    {
        dictionary.Add(key, value);
    }

    public void Update(int key, string value)
    {
        if (dictionary.ContainsKey(key))
        {
            dictionary[key] = value;
        }
        else
        {
            Console.WriteLine("Kunci tidak ditemukan dalam dictionary.");
        }
    }

    public void Delete(int key)
    {
        if (dictionary.ContainsKey(key))
        {
            dictionary.Remove(key);
        }
        else
        {
            Console.WriteLine("Kunci tidak ditemukan dalam dictionary.");
        }
    }
}


}

  
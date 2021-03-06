<Query Kind="Program" />

void Main()
{
    int? parsed = TryParse("Not valid");
    if (parsed != null)
    {
        Console.WriteLine("Parsed to {0}", parsed.Value);
    }
    else
    {
        Console.WriteLine("Couldn't parse");
    }    
}

static int? TryParse(string data)
{
    int ret;
    if (int.TryParse(data, out ret))
    {
        return ret;
    }
    else
    {
        return null;
    }
}

<Query Kind="Program" />

void Main()
{
    DemonstrateTypeof<int>();
}

static internal void DemonstrateTypeof<X>()
{
    Console.WriteLine(typeof(X));

    Console.WriteLine(typeof(List<>));
    Console.WriteLine(typeof(Dictionary<,>));

    Console.WriteLine(typeof(List<X>));
    Console.WriteLine(typeof(Dictionary<string, X>));

    Console.WriteLine(typeof(List<long>));
    Console.WriteLine(typeof(Dictionary<long, Guid>));
}

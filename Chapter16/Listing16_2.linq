<Query Kind="Program">
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

void Main()
{
    ShowInfo(); // Ask the compiler to fill in everything
    ShowInfo("LiesAndDamnedLies.java", -10); // Only the member name will be filled in    
}

static void ShowInfo([CallerFilePath] string file = null,
                     [CallerLineNumber] int line = 0,
                     [CallerMemberName] string member = null)
{
    Console.WriteLine("{0}:{1} - {2}", file, line, member);
}

<Query Kind="Statements">
  <Reference Relative="Chapter11.exe">&lt;MyDocuments&gt;\Computing\Books\C# in Depth\Third edition\Code\LINQPad\Chapter11\Chapter11.exe</Reference>
  <Namespace>Chapter11.Model</Namespace>
</Query>

var query = SampleData.AllUsers.Select(user => user);

foreach (var user in query)
{
    Console.WriteLine(user);
}

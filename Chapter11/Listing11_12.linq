<Query Kind="Statements">
  <Reference Relative="Chapter11.exe">&lt;MyDocuments&gt;\Computing\Books\C# in Depth\Third edition\Code\LINQPad\Chapter11\Chapter11.exe</Reference>
  <Namespace>Chapter11.Model</Namespace>
</Query>

var query = from defect in SampleData.AllDefects 
            join subscription in SampleData.AllSubscriptions on 
                 defect.Project equals subscription.Project
            select new { defect.Summary, subscription.EmailAddress };

foreach (var entry in query)
{
    Console.WriteLine("{0}: {1}", entry.EmailAddress, entry.Summary);
}

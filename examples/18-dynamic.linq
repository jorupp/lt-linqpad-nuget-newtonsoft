<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>System</Namespace>
</Query>

void Main()
{
	dynamic array = JToken.Parse(@"[{""Id"":""789"",""Value"": 456}, {""Id"":""321"",""Value"": 654}]");
	Console.WriteLine(array[0].Id);
	dynamic obj = JToken.Parse(@"{""Id"":""123"",""Value"": 456}");
	Console.WriteLine(obj.Id);
	dynamic value = JToken.Parse(@"456");
	Console.WriteLine(value);
}

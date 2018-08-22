<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
</Query>

void Main()
{
	var array = JToken.Parse(@"[{""Id"":""123"",""Value"": 456}, {""Id"":""321"",""Value"": 654}]");
	array.GetType().FullName.Dump();
	array.ToObject<MyClass[]>().Dump();
	
	var obj = JToken.Parse(@"{""Id"":""123"",""Value"": 456}");
	obj.GetType().FullName.Dump();
	obj.ToObject<MyClass>().Dump();
	
	var value = JToken.Parse(@"456");
	value.GetType().FullName.Dump();
	value.ToObject<int>().Dump();
}

// Define other methods and classes here
public class MyClass
{
	public string Id { get; set; }
	public int Value { get; set;}
}
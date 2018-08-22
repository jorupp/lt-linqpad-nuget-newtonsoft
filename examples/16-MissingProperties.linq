<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
</Query>

void Main()
{
	var obj = JToken.Parse(@"{""Id"":""123"",""Value"": 456}");
	var x = obj.ToObject<MyClass>();
	x.Dump();
}

// Define other methods and classes here
public class MyClass
{
	public string Id { get; set; }
	public int OtherValue { get; set;}
}
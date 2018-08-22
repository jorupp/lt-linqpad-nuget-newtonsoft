<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>System</Namespace>
</Query>

void Main()
{
	var array = JToken.Parse(@"[{""Id"":""123"",""Value"": 456}, {""Id"":""321"",""Value"": 654}]");
	Handle(array);
	var obj = JToken.Parse(@"{""Id"":""123"",""Value"": 456}");
	Handle(obj);
	var value = JToken.Parse(@"456");
	Handle(value);
}

void Handle(JToken input)
{
	switch (input) {
		case JArray array:
			"Array".Dump();
			break;
		case JObject obj:
			"Object".Dump();
			break;
		case JValue value:
			"Value".Dump();
			break;
	}
}

// Define other methods and classes here
public class MyClass
{
	public string Id { get; set; }
	public int Value { get; set;}
}
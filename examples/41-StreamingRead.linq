<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>System</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	// assume this stream is a network call or something
	var stream = new MemoryStream(Encoding.UTF8.GetBytes(@"[{""Id"":""123"",""Value"": 456}, {""Id"":""321"",""Value"": 654}]"));
	MainAsync(stream).Wait();
}

async Task MainAsync(Stream stream)
{
	using(stream) 
	{
		using(var sr = new StreamReader(stream)) 
		{
			// this decodes the incoming data as a stream of tokens (not JTokens though)
			using(var jr = new JsonTextReader(sr)) 
			{
				jr.Read(); // start reading the data
				jr.TokenType.Dump(); // this will be a StartArray
				while (jr.Read() && jr.TokenType != JsonToken.EndArray) // read until we hit the end of the array
				{
					jr.TokenType.Dump(); // this will be a StartObject
					
					// now pointing to the beginning of the object - read it
					var obj = await JToken.ReadFromAsync(jr);
					var realObj = obj.ToObject<MyClass>();
					
					// now process it
					realObj.Dump();
					
					// since we don't reference obj or realObj anymore, they can be garbage-collected
					// even if we keep realObj around, the memory for obj and the stream data behind it can be GCed
				}
			}
		}
	}
}

// Define other methods and classes here
public class MyClass
{
	public string Id { get; set; }
	public int Value { get; set;}
}
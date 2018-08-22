<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
</Query>

void Main()
{
	var obj = JToken.Parse(@"{""Id"":""123"",""Lines"":[{""Quantity"":2,""Item"":{""Id"":""ABC"",""Description"":""Widget 1"",""Price"":4.21}},{""Quantity"":3,""Item"":{""Id"":""QRS"",""Description"":""Widget 2"",""Price"":9.15}}]}");
	var x = obj.ToObject<Order>();
	x.Dump();
}

// Define other methods and classes here
public class Order 
{
	public string Id { get; set; }
	public OrderLine[] Lines { get; set; }
}

public class OrderLine
{
	public int Quantity { get; set; }
	public Item Item { get; set; }
}

public class Item 
{
	public string Id { get; set; }
	public string Description { get; set; }
	public decimal Price { get; set; }
}
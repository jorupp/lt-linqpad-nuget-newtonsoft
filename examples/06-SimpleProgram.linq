<Query Kind="Program" />

void Main()
{
	var x = new Order {
		Id = "123",
		Lines = new [] {
			new OrderLine {
				Quantity = 2,
				Item = new Item {
					Id = "ABC",
					Description = "Widget 1",
					Price = 4.21m,
				}
			},
			new OrderLine {
				Quantity = 3,
				Item = new Item {
					Id = "QRS",
					Description = "Widget 2",
					Price = 9.15m,
				}
			},
		}
	};
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
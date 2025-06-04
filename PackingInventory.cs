class Pack(float maxWeight, float maxVolume)
{
	public List<InventoryItem> Items { get; set; } = [];
    public float maxWeight { get; set; } = maxWeight;
    public float maxVolume { get; set; } = maxVolume;

    public bool AddItem(InventoryItem item)
	{
		if (GetTotalWeight() + item.weight <= maxWeight && GetTotalVolume() + item.volume <= maxVolume)
		{
			Items.Add(item);
			return true;
		}
		return false;
	}
	public float GetTotalWeight()
	{
		float total = 0f;
		foreach (var item in Items)
			total += item.weight;
		return total;
	}
	public float GetTotalVolume()
	{
		float total = 0f;
		foreach (var item in Items)
			total += item.volume;
		return total;
	}
	public int Count() => Items.Count;
}

class InventoryItem
{
	public float weight { get; set; }
	public float volume { get; set; }

	public InventoryItem(float weight, float volume)
	{
		this.weight = weight;
		this.volume = volume;
	}
}

class Arrow : InventoryItem
{
	public Arrow() : base(0.1f, 0.05f) { }
}

class Bow : InventoryItem
{
	public Bow() : base(1f, 4f) { }
}

class Rope : InventoryItem
{
	public Rope() : base(1f, 1.5f) { }
}

class Water : InventoryItem
{
	public Water() : base(2f, 3f) { }
}

class FoodRation : InventoryItem
{
	public FoodRation() : base(1f, 0.5f) { }
}

class Sword : InventoryItem
{
	public Sword() : base(5f, 3f) { }
}
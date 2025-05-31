class Card(Colors color, Rank rank)
{
    public Colors Color { get; } = color;
    public Rank Rank { get; } = rank;

    public bool IsNumber()
	{
		return Rank >= Rank.One && Rank <= Rank.Ten;
	}
	public bool IsSymbol => !IsNumber();

	public void SetOfCards()
	{
		foreach (Colors color in Enum.GetValues(typeof(Colors)))
		{
			foreach (Rank rank in Enum.GetValues(typeof(Rank)))
			{
				Card card = new Card(color, rank);
				Console.WriteLine($"{card.Color} {card.Rank}");
			}
		}
	}
}

enum Colors { Red, Green, Blue, Yellow }
enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }
class Color(byte red, byte green, byte blue)
{
    public byte _red { get; } = red;
    public byte _green { get; } = green;
    public byte _blue { get; } = blue;

    public static Color White() => new (255, 255, 255);
	public static Color Black() => new (0, 0, 0);
	public static Color Red() => new (255, 0, 0);
	public static Color Green() => new (0, 128, 0);
	public static Color Blue() => new (0, 0, 255);
	public static Color Yellow() => new (255, 255, 0);
	public static Color Orange() => new (255, 165, 0);
	public static Color Purple() => new (128, 0, 128);
}
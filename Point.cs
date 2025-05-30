class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Point()
    {
        Point origin = new (0, 0);

    }
    public string ShowCoords()
    {
        return $"({X},{Y})";
    }

}
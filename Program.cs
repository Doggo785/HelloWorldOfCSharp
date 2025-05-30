using System.Threading;

main();
void main()
{
    do
    {
        Console.Clear();
        Console.WriteLine("Welcome my training repo on C#!\n");
        Console.WriteLine("1) Point class");
        Console.WriteLine("2) Color class");
        Console.Write("\nWhich exercise do you want  : ");
        string exercise = Console.ReadLine() ?? "";
        switch (exercise)
        {
            case "1":
                Console.Clear();
                PointExercice();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            case "2":
                Console.Clear();
                ColorExercice();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Invalid choice, exiting.");
                Thread.Sleep(1000);
                return;
        }
    }
    while (true);

}

void PointExercice() {
    Point Point1 = new(2, 3);
    Point Point2 = new(-4, 0);

    Console.WriteLine($"Here is the Coords for the first point : ({Point1.X},{Point1.Y})");
    Console.WriteLine($"Here is the Coords for the second point : ({Point2.X},{Point2.Y})");

}

void ColorExercice() {
    Color WeirdColor = new(255, 128, 64);
    Color White = Color.White();
    Color Black = Color.Black();
    Color Red = Color.Red();
    Color Green = Color.Green();
    Color Blue = Color.Blue();
    Color Yellow = Color.Yellow();
    Color Orange = Color.Orange();
    Color Purple = Color.Purple();
    Console.WriteLine("Here are the colors defined in the Color class:");
    Console.WriteLine($"White: ({White._red}, {White._green}, {White._blue})");
    Console.WriteLine($"Black: ({Black._red}, {Black._green}, {Black._blue})");
    Console.WriteLine($"Red: ({Red._red}, {Red._green}, {Red._blue})");
    Console.WriteLine($"Green: ({Green._red}, {Green._green}, {Green._blue})");
    Console.WriteLine($"Blue: ({Blue._red}, {Blue._green}, {Blue._blue})");
    Console.WriteLine($"Yellow: ({Yellow._red}, {Yellow._green}, {Yellow._blue})");
    Console.WriteLine($"Orange: ({Orange._red}, {Orange._green}, {Orange._blue})");
    Console.WriteLine($"Purple: ({Purple._red}, {Purple._green}, {Purple._blue})");
    Console.WriteLine($"Here is a custom color : ({WeirdColor._red}, {WeirdColor._green}, {WeirdColor._blue})");
}
using System.Threading;

main();
void main()
{
    do
    {
        Console.Clear();
        Console.WriteLine("Welcome my training repo on C#!\n");
        Console.WriteLine("1) Point class");
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

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
        Console.WriteLine("3) Card class");
        Console.WriteLine("4) The Locked Door");
        Console.WriteLine("5) Password Validator");
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
            case "3":
                Console.Clear();
                CardExercice();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            case "4":
                Console.Clear();
                LockedDoorExercice();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            case "5":
                Console.Clear();
                PasswordValidatorExercice();
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

void CardExercice() {
    Card card = new(Colors.Red, Rank.Ten);
    Console.WriteLine($"Card Color: {card.Color}, Rank: {card.Rank}");
    Console.WriteLine($"Is the card a number? {card.IsNumber()}");
    Console.WriteLine($"Is the card a symbol? {card.IsSymbol}");
    
    Console.WriteLine("\nAll cards in the deck:");
    card.SetOfCards();
}

void LockedDoorExercice() {
    bool running = true;
    Console.WriteLine("Welcome to the Locked Door exercise!");
    Console.WriteLine("You can open, close, lock, unlock, or change the passcode of the door.\n");
    Console.WriteLine("Please enter the initial passcode for the door (an integer): ");
    Door door = new(int.Parse(Console.ReadLine() ?? "0000"));
    Console.WriteLine("Door created with initial passcode.\n");
    Thread.Sleep(2000);
    Console.Clear();
    while (running)
    {
        Console.WriteLine($"Current door state: {door.State}");
        Console.WriteLine("Choose an action: Open, Close, Lock, Unlock, ChangePasscode, Exit");
        string action = Console.ReadLine()?.ToLower() ?? "";
        if (action == "exit") break;
        switch (action)
        {
            case "open":
                door.Open();
                Thread.Sleep(2000);
                Console.Clear();
                break;
            case "close":
                door.Close();
                Thread.Sleep(2000);
                Console.Clear();
                break;
            case "lock":
                Console.Write("Enter passcode to lock: ");
                int lockPasscode = int.Parse(Console.ReadLine() ?? "0");
                door.Lock(lockPasscode);
                Thread.Sleep(2000);
                Console.Clear();
                break;
            case "unlock":
                Console.Write("Enter passcode to unlock: ");
                int unlockPasscode = int.Parse(Console.ReadLine() ?? "0");
                door.Unlock(unlockPasscode);
                Thread.Sleep(2000);
                Console.Clear();
                break;
            case "changepasscode":
                Console.Write("Enter old passcode: ");
                int oldPasscode = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("Enter new passcode: ");
                int newPasscode = int.Parse(Console.ReadLine() ?? "0");
                door.ChangePasscode(oldPasscode, newPasscode);
                Thread.Sleep(2000);
                Console.Clear();
                break;
            case "exit":
                running = false;
                break;
            default:
                Console.WriteLine("Invalid action. Try again.");
                Thread.Sleep(1500);
                break;
        }
    }
}

void PasswordValidatorExercice() {
    PasswordValidator validator = new();
    Console.WriteLine("Welcome to the Password Validator exercise!");
    Console.WriteLine("Please enter a password to validate: ");
    string password = Console.ReadLine() ?? "";
    bool isValid = validator.IsValid(password);
    if (isValid)
    {
        Console.WriteLine("The password is valid.");
    }
    else
    {
        Console.WriteLine("The password is invalid.");
    }
}
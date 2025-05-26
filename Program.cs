// Exercice 1 - Hello World
/*
string name;
name = "Doggo";

Console.WriteLine("Hello, World!");
Console.WriteLine("Im a GOD!");
Console.WriteLine("Im the one that will save your Wolrd!");
Console.WriteLine("I Will defeat the Uncoded One, i Promise..");
Console.WriteLine("I will be the one to save you all!");
Console.WriteLine("My name is " + name + "!");
*/

// Exercice 2 - Consolas and Telim
/*
string client;

Console.WriteLine("Bread is ready!");
Console.WriteLine("Who is the Bread for ?");
client = Console.ReadLine();
Console.WriteLine("Noted : The bread is for " + client + "!"); 
*/

// Exercice 3 - The Thing Namer 3000
/*
Console.WriteLine("What kind of thing are we talking about?");
string Subject = Console.ReadLine(); // Subject name 
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string Adjective = Console.ReadLine(); // Adjective of subject
string c = "of Doom"; // String
string d = "3000"; // String
Console.WriteLine("The " + Adjective + " " + Subject + " " + c + " " + d + "!");
*/

// Exercice 4 - The Variable Shop 
/*
string unTexte = "coucou";
byte unByte = 255;
sbyte unSByte = -128;
short unShort = 32767;
ushort unUShort = 65535;
int unInt = 564654;
uint unUInt = 4294967295;
long unLong = 1234567890123456789;
ulong unULong = 18446744073709551615;
float unFloat = 3.14f;
double unDouble = 3.14159265358979323846;
decimal unDecimal = 3.141592653589793238462643383279502884197169399375105820974944592307816406286M;
bool unBool = true;
char unChar = 'A';

Console.WriteLine("Texte : " + unTexte);
Console.WriteLine("Byte : " + unByte);
Console.WriteLine("SByte : " + unSByte);
Console.WriteLine("Short : " + unShort);
Console.WriteLine("UShort : " + unUShort);
Console.WriteLine("Int : " + unInt);
Console.WriteLine("UInt : " + unUInt);
Console.WriteLine("Long : " + unLong);
Console.WriteLine("ULong : " + unULong);
Console.WriteLine("Float : " + unFloat);
Console.WriteLine("Double : " + unDouble);
Console.WriteLine("Decimal : " + unDecimal);
Console.WriteLine("Bool : " + unBool);
Console.WriteLine("Char : " + unChar);
*/

// Exercice 5 - The Variable Shop Returns

/*
string unTexte = "coucou";
unTexte = "Hello World!";
byte unByte = 255;
unByte = 0;
sbyte unSByte = -128;
short unShort = 32767;
ushort unUShort = 65535;
int unInt = 564654;
uint unUInt = 4294967295;
long unLong = 1234567890123456789;
ulong unULong = 18446744073709551615;
float unFloat = 3.14f;
double unDouble = 3.14159265358979323846;
decimal unDecimal = 3.141592653589793238462643383279502884197169399375105820974944592307816406286M;
bool unBool = true;
char unChar = 'A';

Console.WriteLine("Texte : " + unTexte);
Console.WriteLine("Byte : " + unByte);
Console.WriteLine("SByte : " + unSByte);
Console.WriteLine("Short : " + unShort);
Console.WriteLine("UShort : " + unUShort);
Console.WriteLine("Int : " + unInt);
Console.WriteLine("UInt : " + unUInt);
Console.WriteLine("Long : " + unLong);
Console.WriteLine("ULong : " + unULong);
Console.WriteLine("Float : " + unFloat);
Console.WriteLine("Double : " + unDouble);
Console.WriteLine("Decimal : " + unDecimal);
Console.WriteLine("Bool : " + unBool);
Console.WriteLine("Char : " + unChar);
*/

// Exercice 6 - The Triangle Farmer
/*
Console.WriteLine("How much is this Triangle Worth 3000");
Console.WriteLine("What is the base of the triangle?");
float baseTriangle;
if (!float.TryParse(Console.ReadLine(), out baseTriangle))
{
    Console.WriteLine("Invalid input. Please enter a number. You may try to put a ',' instead of a '.'");
    return;
}
Console.WriteLine("What is the height of the triangle?");
float heightTriangle;
if (!float.TryParse(Console.ReadLine(), out heightTriangle))
{
    Console.WriteLine("Invalid input. Please enter a number. You may try to put a ',' instead of a '.'");
    return;
}
Console.WriteLine("The area of the triangle is " + (baseTriangle * heightTriangle) / 2 + ".");
*/

// Exercice 7 - The Four Sisters and the Duckbear
/*
int numberOfEggs;
Console.WriteLine("How many eggs do you have today ?");
numberOfEggs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Each sister will get " + numberOfEggs/4 + " egg(s) and the Duckbear will eat " + numberOfEggs%4 + " egg(s)");
*/

// Exercice 8 - The Dominion of Kings

/*
int estate;
int duchy;
int province;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Title= "Who as the best kingdom 3000";
Console.Write("Press any key to start...");
Console.ReadKey(true);
//Console.Beep();
Console.Clear();
Console.WriteLine("How many estate do you have ?");
estate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many duchy do you have ?");
duchy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many province do you have ?");
province = Convert.ToInt32(Console.ReadLine());
estate *= 1;
duchy *= 3;
province *= 6;
Console.WriteLine($"Your kindom is worth {(estate + duchy + province)} points !");
*/

// Exercice 9 - The Defense of Consolas
/*
Console.Title = "Defense of Consolas";

Byte targetedRow;
Byte targetedColumn;

Console.Write("Target Row ? ");
targetedRow = Convert.ToByte(Console.ReadLine());
Console.Write("Target Column ? ");
targetedColumn = Convert.ToByte(Console.ReadLine());
Console.Write("Crew needed on : \n");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write($"({targetedRow - 1},{targetedColumn})\n({targetedRow},{targetedColumn - 1})\n({targetedRow + 1},{targetedColumn})\n({targetedRow},{targetedColumn + 1})\n"); // Make a cross around the targeted cell
Console.Beep(); // Beep Bop sound
Console.ResetColor(); // Reset la couleur de la console
*/

// Exercice 10 - Repairing the Clocktower
/*
int number;
Console.Write("What is the number of the clock ? ");
number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0) // If the number is even
    Console.WriteLine("Tick");
else
    Console.WriteLine("Tock");
*/

// Exercice 11 - Watchtower
/*
sbyte x;
sbyte y;

Console.Write("What is the x value ? ");
x = Convert.ToSByte(Console.ReadLine());
Console.Write("What is the y value ? ");
y = Convert.ToSByte(Console.ReadLine());

if (x < 0 && y < 0) Console.Write("The enemy is to the northwest!");
else if (x < 0 && y > 0) Console.Write("The enemy is to the southwest!");
else if (x > 0 && y < 0) Console.Write("The enemy is to the northeast!");
else if (x > 0 && y > 0) Console.Write("The enemy is to the southeast!");
else if (x == 0 && y < 0) Console.Write("The enemy is to the west!");
else if (x == 0 && y > 0) Console.Write("The enemy is to the east!");
else if (y == 0 && x < 0) Console.Write("The enemy is to the north!");
else if (y == 0 && x > 0) Console.Write("The enemy is to the south!");
else Console.Write("The enemy is at your position!");
*/

// Exercice 12 - Buying Inventory
/*
int itemNumber;

Console.Write("The following items are available:\r\n" +
    "1 – Rope\r\n" +
    "2 – Torches\r\n" +
    "3 – Climbing Equipment\r\n" +
    "4 – Clean Water\r\n" +
    "5 – Machete\r\n" +
    "6 – Canoe\r\n" +
    "7 – Food Supplies\r\n" +
    "What number do you want to see the price of : ");
itemNumber = Convert.ToInt32(Console.ReadLine());
switch (itemNumber)
{
    case 1:
        Console.WriteLine("The price of the Rope is 10 gold.");
        break;
    case 2:
        Console.WriteLine("The price of the Torches is 15 gold.");
        break;
    case 3:
        Console.WriteLine("The price of the Climbing Equipment is 25 gold.");
        break;
    case 4:
        Console.WriteLine("The price of the Clean Water is 1 gold.");
        break;
    case 5:
        Console.WriteLine("The price of the Machete is 20 gold.");
        break;
    case 6:
        Console.WriteLine("The price of the Canoe is 200 gold.");
        break;
    case 7:
        Console.WriteLine("The price of the Food Supplies is 1 gold.");
        break;
    default:
        Console.WriteLine("This item does not exist!");
        break;
}
*/

// Exercice 13 - Discounted Inventory

/*
int itemNumber;
string name;
int price=0;

Console.Write("The following items are available:\r\n" +
    "1 – Rope\r\n" +
    "2 – Torches\r\n" +
    "3 – Climbing Equipment\r\n" +
    "4 – Clean Water\r\n" +
    "5 – Machete\r\n" +
    "6 – Canoe\r\n" +
    "7 – Food Supplies\r\n" +
    "What number do you want to see the price of : ");
itemNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("What is your name ? ");
name = Convert.ToString(Console.ReadLine());
switch (itemNumber)
{
    case 1:
        price = 10;
        break;
    case 2:
        price = 15;
        break;
    case 3:
        price = 1;
        break;
    case 4:
        price = 1;
        break;
    case 5:
        price = 20;
        break;
    case 6:
        price = 200;
        break;
    case 7:
        price = 1;
        break;
    default:
        Console.WriteLine("This item does not exist!");
        break;
}
if (price>0)
    Console.WriteLine($"The price of the Climbing Equipment is {(name == "Doggo" ? (float)price/2 : price )} gold.");
*/

// Exercice 14 - The Prototype

/*
using System.Security.Cryptography;

int guessNumber = RandomNumberGenerator.GetInt32(101); // Generate a random int between 0 and 100
int userNumber;


Console.WriteLine("Welcome to the guess the number 3000 Game !");

do
{
    //Console.WriteLine("What is your guess (0-100): ");
    //userNumber = Convert.ToInt32(Console.ReadLine());
    userNumber = AskForNumberInRange("What is your guess (0-100): ", 0, 100);
    if (userNumber > 100 || userNumber < 0)
        Console.WriteLine($"{userNumber} is not between 0 and 100, retry.");
    else if (userNumber > guessNumber)
        Console.WriteLine($"{userNumber} is to high !");
    else if (userNumber < guessNumber)
        Console.WriteLine($"{userNumber} is to low !");
    else if (userNumber == guessNumber)
        Console.WriteLine($"{userNumber} is the correct answer !");

}
while (userNumber!=guessNumber);
*/

// Exercice 15 - The Magic Cannon

/*
for (int turnOfCrank = 1; turnOfCrank < 101; turnOfCrank++)
{
    if (turnOfCrank % 3 == 0 && turnOfCrank % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"{turnOfCrank, -3}: COMBINED ULTRA BLAST");
    }
    else if (turnOfCrank % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{turnOfCrank, -3}: Fire");
    }
    else if (turnOfCrank % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{turnOfCrank,-3}: Electric");
    }

    else
    {
        Console.ResetColor();
        Console.WriteLine($"{turnOfCrank,-3}: Normal");
    }
}
Console.ResetColor();
*/

// Exercice 16 - The Replicator of D’To

/*
int[] array = new int[5];
int[] arrayDupe = new int[5];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{"[" + (i+1) + "/5]",-8} Enter a number to fill the array : ");
    array[i]=Convert.ToInt32(Console.ReadLine());
}


for (int i = 0; i < array.Length; i++)
{
    arrayDupe[i] = array[i];
    Console.WriteLine($"arrayDupe[{i}] = {arrayDupe[i]}");
}
Console.WriteLine("The original array is : ");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"array[{i}] = {array[i]}");
}
Console.WriteLine("The duplicated array is : ");
for (int i = 0; i < arrayDupe.Length; i++)
{
    Console.WriteLine($"arrayDupe[{i}] = {arrayDupe[i]}");
}
*/

// Exercice 17 - The Laws of Freach

/*
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; 
foreach (int number in array)
{
    if (number < currentSmallest)
        currentSmallest = number;
}
Console.WriteLine(currentSmallest);
*/

// Testing matrix
/*
int[,] matrix = new int[3, 4] { {1,2,3,4}, {5,6,7,8}, {9,10,11,12} }; // 3 rows, 4 columns

Console.WriteLine($"Matrix : {matrix[1, 2]}");

int[,,] biggerMatrix = new int[2,3, 4] { 
    { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } },
    { { 13, 14, 15, 16 }, { 17, 18, 19, 20 }, { 21, 22, 23, 24 } } 
}; 

Console.WriteLine($"Bigger matrix : {biggerMatrix[1, 2, 3]}"); 
*/

// Testing functions
/*
void Countdown(int number)
{
    for (int i = number; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
};
Countdown(10);

*/

// Exercice 18 - Taking a Number

int AskForNumber(string text)
{
    int number;
    Console.Write(text);
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    int number;
    do
    {
        Console.WriteLine(text);
        number = Convert.ToInt32(Console.ReadLine());
        if (number < min || number > max)
            Console.WriteLine($"Please enter a number between {min} and {max}.");
    } while (number < min || number > max);
    return number;
}

// Exercice 19 - Countdown

/*
void Countdown(int number)
{
    if (number == 0)
        Console.WriteLine("0");
    else
    {
        Console.WriteLine(number);
        Countdown(number - 1);
    }
};

Countdown(10);
*/

// Memory test

/*
string heapStr = "Heap String"; // This is stored in the heap
string heapStrDupe = heapStr; // This is a reference to the same string in the heap

Console.WriteLine($"Heap String equals : {heapStr==heapStrDupe}");
Console.WriteLine($"Heap String is the same object as Heap String Dupe : {ReferenceEquals(heapStr, heapStrDupe)}");

string heapStr2 = "Heap String"; 
string heapStrDupe2 = "Heap String"; 

Console.WriteLine($"Heap String equals : {heapStr2 == heapStrDupe2}");
Console.WriteLine($"Heap String is the same object as Heap String Dupe : {ReferenceEquals(heapStr2, heapStrDupe2)}");

int[] array = new int[] { 1, 2, 3 }; // This is stored in the heap
int[] arrayDupe = array; // This is a reference to the same array in the heap

Console.WriteLine("Array equals : " + (array == arrayDupe));
Console.WriteLine("Array is the same object as Array Dupe : " + ReferenceEquals(array, arrayDupe));

array[array.Length - 1] = 4; // Change the last element of the array
Console.WriteLine("Array after change : " + string.Join(", ", array));
Console.WriteLine("Array Dupe after change : " + string.Join(", ", arrayDupe)); // Both arrays are the same object, so they are both changed

*/

// Final test - First Part - Hunting the Manticore

/*
ChooseManticoreDistance();

void ChooseManticoreDistance()
{
    Console.WriteLine("Player 1, enter the distance between the Manticore and the city : ");
    byte distanceFromManticore = Convert.ToByte(Console.ReadLine());
    if (distanceFromManticore > 100 || distanceFromManticore < 0)
    {
        Console.WriteLine("Please enter a number between 0 and 100 !");
        ChooseManticoreDistance();
    }
    else
    {
        HuntingTheMantricore(distanceFromManticore);
    }
}


sbyte CannonRolls(byte round)
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("COMBINED ULTRA BLAST ACTIVATED !! You will deal 10 damage !");
        return Convert.ToSByte(10);
    }
    else if (round % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire cannon activated ! You will deal 3 damage !");
        return Convert.ToSByte(3);
    }
    else if (round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Electric cannon activated ! You will deal 3 damage !");
        return Convert.ToSByte(3);
    }

    else
    {
        Console.ResetColor();
        Console.WriteLine("Normal cannon shot. You will deal 1 damage");
        return Convert.ToSByte(1);
    }
}

bool HitOrMiss(byte distanceFromManticore)
{
    Console.Write("Enter the position of the Manticore : ");
    byte Guess = Convert.ToByte(Console.ReadLine());
    if (Guess < 0 || Guess > 100)
    {
        Console.WriteLine("Wrong position ! It should be between 0 and 100, try again !");
        return HitOrMiss(distanceFromManticore);
    }
    else if (distanceFromManticore == Guess)
    {
        return true;
    }
    else if (distanceFromManticore > Guess)
    {
        Console.WriteLine("The position entered was too high");
        return false;
    }
    else if (distanceFromManticore < Guess)
    {
        Console.WriteLine("The postion entered was too low");
        return false;
    }
    else
    {
        return false;
    }
}

void HuntingTheMantricore(byte distanceFromManticore)
{
    sbyte cityHealth = 15;
    sbyte manticoreHealth = 10;
    sbyte damage;
    Console.Clear();
    Console.WriteLine("Player 2, it's your turn !");
    for (byte round = 1; cityHealth >  0 && manticoreHealth > 0; round++)
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine(
    $"{"STATUS :",-12}{"Round : " + round,-12}{"City : " + cityHealth + "/15",-16}{"Manticore : " + manticoreHealth + "/10",-20}"
);
        damage = CannonRolls(round);
        Console.ResetColor();
        //bool hitOrMiss = HitOrMiss(distanceFromManticore);
        if (HitOrMiss(distanceFromManticore))
        {
            Console.WriteLine($"You hit the Manticore with {damage} damage !");
            manticoreHealth -= damage;

        }
        cityHealth--;
    }
    if (cityHealth <= 0) { 
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\nThe city was entirely destroy.. You lost.\n");
    }
    else if (manticoreHealth <= 0) { 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\nYou just killed the Mantricore ! Thank you for saving the city of Consolas !\n");
    }
    Console.ResetColor();
}

*/

// PART 2 - Exercice 1 - Simula’s Test 

Chest status = Chest.Locked;
string choice;
Chest Close(Chest status)
{
    if (status == Chest.Open) {
        Console.WriteLine("Chest successfully closed !");
        return Chest.Closed;
    }
    else
    {
        Console.WriteLine("The chest cant be closed..");
        return status;
    }

}
Chest Unlock(Chest status)
{
    if (status == Chest.Locked)
    {
        Console.WriteLine("Chest successfully unlocked !");
        return Chest.Closed;
    }
    else
    {
        Console.WriteLine("The chest cant be unlocked..");
        return status;
    }

}
Chest Open(Chest status)
{
    if (status == Chest.Closed)
    {
        Console.WriteLine("Chest successfully opened !");
        return Chest.Open;
    }
    else
    {
        Console.WriteLine("The chest cant be opened..");
        return status;
    }

}
Chest Lock(Chest status)
{
    if (status == Chest.Closed)
    {
        Console.WriteLine("Chest successfully locked !");
        return Chest.Locked;
    }
    else
    {
        Console.WriteLine("The chest cant be locked..");
        return status;
    }

}

do
{
    if (status == Chest.Closed)
        Console.Write("The chest is closed. What do you want to do? ");
    else if (status == Chest.Locked)
        Console.Write("The chest is locked. What do you want to do? ");
    else if (status == Chest.Open)
        Console.Write("The chest is opened. What do you want to do? ");
    // Make a switch for Lock, Unlock, Open, Close with Console.ReadLine();
    choice = Console.ReadLine();
    switch (choice)
    {
        case "unlock":
            status = Unlock(status);
            break;
        case "lock":
            status = Lock(status);
            break;
        case "open":
            status = Open(status);
            break;
        case "close":
            status = Close(status);
            break;

    }
}
while (true);

enum Chest { Locked, Open, Closed  }

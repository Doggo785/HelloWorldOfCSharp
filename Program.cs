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

int estate;
int duchy;
int province;

Console.WriteLine("Who as the best kingdom 3000");
Console.WriteLine("How many estate do you have ?");
estate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many duchy do you have ?");
duchy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many province do you have ?");
province = Convert.ToInt32(Console.ReadLine());
estate *= 1;
duchy *= 3;
province *= 6;
Console.WriteLine("Your kindom is worth " +  (estate + duchy + province) + " points !");   
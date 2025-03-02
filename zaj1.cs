
using System.ComponentModel;

Console.WriteLine("Podaj swoje imię: ");
var name = Console.ReadLine();
Console.WriteLine("Hello " +  name);

//int result = 5 + 9;
//Console.WriteLine(result);

int number = 7;
float money = 99.99f;
string text = "Dzień dobry";
bool isLogged = true;
char myChar = 'k';
decimal price = 199.99m;

Console.WriteLine($"Number: {number}");
Console.WriteLine($"Money: {money}");
Console.WriteLine($"Text: {text}");
Console.WriteLine($"Is Logged: {isLogged}");
Console.WriteLine($"My Char: {myChar}");
Console.WriteLine($"Price: {price}");

string myAge = "Age: ";
int wifeAge = 18;
string result = myAge + wifeAge;

Console.WriteLine(result);

bool isTrue = true;
bool isFalse = false;
bool isReallyTrue = true;

bool and = isTrue && isFalse;
bool or = isTrue || isReallyTrue;
bool negative = !isFalse;

Console.WriteLine($"AND: {and}");
Console.WriteLine($"OR: {or}");
Console.WriteLine($"NEGATION: {negative}");

/*int a = 5, b = 12;
int add = a + b;
int sub  = a - b;
float div = (float)a / b;
int mul = a * b;
int mod = a % b;

Console.WriteLine("a + b = " + add);
Console.WriteLine("a - b = " + sub);
Console.WriteLine("a / b = " + div);
Console.WriteLine("a * b = " + mul);
Console.WriteLine("a % b = " + mod);*/

string a = "Ala ", b = "ma ", c = "kota. ";
string result1 =  a + b + c;
Console.WriteLine(result1);
// See https://aka.ms/new-console-template for more information

/*
Human human = new Human();
human.FirstName = "Jakub";
human.LastName = "Klimek";
human.SayHello();

public class Human
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void SayHello()
    {
        Console.WriteLine($"{FirstName} {LastName} says Hello");
    }
}*/

// ZADANIE 1

string[] colors = { "niebieski", "zielony", "żółty", "czerwony" };

Console.WriteLine($"Mój pierwszy kolor to: {colors[0]}.");
Console.WriteLine($"Mój ostatni kolor to: {colors[^1]}.");


// ZADANIE 2

int[] numbers = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89};

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Liczba: {numbers[i]} ");
}

foreach (int number in numbers)
{
    Console.WriteLine($"Liczba: {number}");
}

int a = 0;
while  (a < 10)
{
    Console.WriteLine($"Liczba: {numbers[a]}");
    a++;
}


// ZADANIE 3
List<string> fruits = new List<string>();
fruits.Add("Jabłko");
fruits.Add("Banan");
fruits.Add("Truskawka");
fruits.Add("Mandarynka");
fruits.Add("Jagoda");

foreach (string fruit in fruits)
{
    Console.Write(fruit + ", ");
}

Console.WriteLine();

fruits.Remove(fruits[0]);
fruits.RemoveAt(fruits.Count-1);

foreach (string fruit in fruits)
{
    Console.Write(fruit + ", ");
}


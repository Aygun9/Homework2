Console.Write("Insert number");
int number = int.Parse(Console.ReadLine());
if (number <= 99)
{
    Console.WriteLine("No 3rd digit");
}
if ((number >= 100) && (number <= 999))
{
    int n3 = number % 10;
    Console.WriteLine($"3rd digit :  -> {n3}");
}
if (number > 999)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    {
        Console.WriteLine($"3rd digit :  -> {number % 10}");
    }
}
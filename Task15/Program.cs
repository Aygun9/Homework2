Console.Write(" Please Insert week day number");
int number = int.Parse(Console.ReadLine());
if ((number >= 1) && (number <= 5))
{
    Console.WriteLine("No - weekday");
}
if ((number >= 6) && (number <= 7))
{
    Console.WriteLine("yes - weekend");
}
else
{
    Console.WriteLine("Incorrect number ");
}
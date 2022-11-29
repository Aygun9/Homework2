Console.Write("Insert 3 digit number");
int number = int.Parse(Console.ReadLine());
int n1 = number / 10;
int n2 = n1 % 10;
Console.WriteLine("Middle digit : " + n2);

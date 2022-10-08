Console.Write($"Введите одно число: ");
int a = 0;
string number = Console.ReadLine()!;
a = int.Parse(number);
int b = a%2;
if (b == 0)
{
    Console.WriteLine("Ваше число четное");
}
if (b != 0)
{
    Console.WriteLine("Ваше число нечетное");
}

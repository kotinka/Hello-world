Console.Write($"Введите одно число: ");
int a = 0;
string numberA = Console.ReadLine()!;
a = int.Parse(numberA);

Console.Write($"Введите другое число: ");
int b = 0;
string numberB = Console.ReadLine()!;
b = int.Parse(numberB);



int max = a;
int min = b;

if (b > max )  {max = b; min = a;}

Console.Write("Большее число - ");
Console.WriteLine( max);
Console.Write("Меньшее число - ");
Console.WriteLine( min);
Console.ReadKey();



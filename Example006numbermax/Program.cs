Console.Write($"Введите одно число: ");
int a = 0;
string numberA = Console.ReadLine()!;
a = int.Parse(numberA);

Console.Write($"Введите другое число: ");
int b = 0;
string numberB = Console.ReadLine()!;
b = int.Parse(numberB);

Console.Write($"Введите третье число: ");
int c = 0;
string numberC = Console.ReadLine()!;
c = int.Parse(numberC);



int max = a;

if (a > max ) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
Console.ReadKey();

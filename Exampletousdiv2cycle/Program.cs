// See https://aka.ms/new-console-template for more information
Console.Write($"Введите одно число: ");
int n = 1;
string number = Console.ReadLine()!;
n = int.Parse(number);

int i = 1;
while (i <= n)
{int b = i%2;
if (b == 0)

    {Console.WriteLine($"{i}");
    
    }
     i+=1;
}


Console.WriteLine("Введите первое число:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int numberN = Convert.ToInt32(Console.ReadLine());

int Pov(int a, int b)
{
    if (b == 0) return 1;
    return a * Pov(a, b - 1);
}

if (numberN < 0)
    Console.WriteLine(1/(double)Pov(numberM, -numberN));
else
    Console.WriteLine(Pov(numberM, numberN));
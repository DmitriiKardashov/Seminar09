﻿
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumOfDigits(number);

int SumOfDigits(int num)
{
    if (num == 0) return 0;
    return num%10 + SumOfDigits(num/10);
}
Console.WriteLine(SumOfDigits(number));

Console.WriteLine("Введите первое число:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM == numberN)
{
     Console.WriteLine("Некорректный ввод.");
}
else
{
    int sumary = SumNumbersOfMToN(numberM, numberN);
    Console.Write($"Сумма чисел от {numberM} до {numberN} равна {sumary}.");
}

int SumNumbersOfMToN(int numM, int numN)
{
    int sum = numM;
    if (numM == numN) return numM;
    else if (numM < numN)
    {
       sum = numM + SumNumbersOfMToN(numM + 1, numN);
        return sum;
    }
    else
    {
        sum = numN + SumNumbersOfMToN(numM, numN + 1);
        return sum;
    }
    
}
/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */

Console.WriteLine();
Console.WriteLine("-----------Task 64-------------");
Console.WriteLine();

int countDown = InputNumber("Input number: ");

void CountDown(int firstNum) {
    Console.Write(firstNum);
    if (firstNum > 1)
    {
        CountDown(firstNum - 1);
    }
}

CountDown(countDown);
Console.WriteLine();

int InputNumber(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Console.WriteLine();
Console.WriteLine("-----------Task 66-------------");
Console.WriteLine();

 /*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

int numM = InputNumber("Input number M: ");
int numN = InputNumber("Input number N: ");

int SumNaturNumber(int m, int n) {
    int i = m;
    int result  = 0;
    while (i <= n)
    {
        result += i;
        i += 1;
    }
    Console.WriteLine(result);
    return result;
}

SumNaturNumber(numM, numN);
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("-----------Task 68-------------");
Console.WriteLine();


/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int numberM = InputNumber("Input number M: ");
int numberN = InputNumber("Input number N: ");

int Akkerman(int m, int n) {
    if (m == 0) {
        return n + 1;
    } else if (n == 0) {
        return Akkerman(m-1, 1);
    } else {
        return Akkerman(m-1, Akkerman(m, n-1));
    }
}


Console.WriteLine(Akkerman(numberM, numberN));
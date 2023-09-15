// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//step1
int InputNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine()!);
}

//step2
void PrintNumbersFromNToOne(int n)
{
  if (n > 1)
  {
    Console.Write(n + ", ");
    PrintNumbersFromNToOne(n - 1);
  }
  else if (n == 1)
  {
    Console.Write(n);
    PrintNumbersFromNToOne(n - 1);
  }
  else
  {
    return;
  }
}

//step3
int number = InputNum("Введите число: ");
Console.Write($"N = {number} -> \"");
PrintNumbersFromNToOne(number);
Console.Write($"\"");
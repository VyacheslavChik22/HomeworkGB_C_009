/*Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30
*/

//step1
int InputNumbers(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine()!);
}

//step2
int count = 0;
void PrintSumNumbersFromMToN(int m, int n)
{
  if (m <= n)
  {
    PrintSumNumbersFromMToN(m + 1, n);
    count += m;
  }
}

//step3
int valueM = InputNumbers("Введите значение M: ");
int valueN = InputNumbers("Введите значение N: ");
PrintSumNumbersFromMToN(valueM, valueN);
Console.Write($"M = {valueM}; N = {valueN} -> {count} ");
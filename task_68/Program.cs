/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29
*/

//step1
uint InputNumbers(string text)
{
  Console.Write(text);
  return uint.Parse(Console.ReadLine()!);
}

//step2
uint searchResult(uint m, uint n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (n == 0)
  {
    return searchResult(m - 1, 1);
  }
  else return searchResult(m - 1, searchResult(m, n - 1));
}

//step3
uint valueM = InputNumbers("Введите значение M: ");
uint valueN = InputNumbers("Введите значение N: ");
uint resultFuncAkkerman = searchResult(valueM, valueN);
Console.Write($"m = {valueM}, n = {valueN} -> A({valueM}, {valueN}) = {resultFuncAkkerman}");
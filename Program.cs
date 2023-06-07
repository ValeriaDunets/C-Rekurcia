//Задача 64
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от М до N
//1.....10
/*void ShowNumber (int num1, int num2)
{
    if (num1 < num2) ShowNumber(num1 + 1, num2);
    Console.WriteLine(num1 + " ");
}
ShowNumber(1, 10);
*/


//Задача 66
// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов
// в промежутке от М до N

/*int SumNum (int num1, int num2)
{   
    if (num1 == num2) return num2;
    else return num1 + SumNum(num1 + 1, num2);
}
int num1 = 2;
int num2 = 9;
    Console.WriteLine($"Summ of elements is {SumNum(num1,num2)}");
SumNum(2, 9);
*/

//Задача 68
// Напишите прорамму вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа М и Н

int Akkerman (int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else  return Akkerman(m - 1, Akkerman(m, n - 1));
}
int m = 3;
int n = 3;
Console.WriteLine($"Function of Akkermsn is {Akkerman(m,n)}");
int result = Akkerman(m, n);
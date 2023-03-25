// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("В этом массиве: ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
int count = 0;

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
//[3, 7, 23, 12] => 19
//[-4, -6, 89, 6] => 0
// Задание 36

/*Console.WriteLine("Введите число!");
int Number = Convert.ToInt32(Console.ReadLine());

int[] Massiv = new int[Number];
int SumOfOddNum = 0;

void FillMassiv(int[] Massiv)
{
    for (int i = 0; i < Massiv.Length; i++)
    {
        Massiv[i] = new Random().Next(1, 100);
    }
    var str = string.Join(" ", Massiv);
    Console.WriteLine(str);
}

int SummNumber(int[] Massiv, int SumOfOddNum)
{
    for (int i = 1; i < Massiv.Length; i = i + 2)
    {
        if (i % 2 > 0)   //сделал дополнительную проверку условия номера элемента (отрицательный или нет), хотя можно и без if из-за условия в for
        {
            SumOfOddNum = SumOfOddNum + Massiv[i];
        }
    }
    return SumOfOddNum;
}
FillMassiv(Massiv);
Console.WriteLine(SummNumber(Massiv, SumOfOddNum));*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


Console.WriteLine("Введите число!");
int Number = Convert.ToInt32(Console.ReadLine());
double min;
double max;
double Raznica = 0;
bool vuzov;

double[] Massiv = new double[Number];
void FillMassiv(double[] Massiv)
{
    for (int i = 0; i < Massiv.Length; i++)
    {
        Massiv[i] = Math.Round((new Random().NextDouble()) * 100, 2, MidpointRounding.AwayFromZero);
    }
    var str = string.Join(" ", Massiv);
    Console.WriteLine(str);
}




double Sravnenie(bool vuzov, double[] Massiv)
{
// var str = string.Join(" ", Massiv);
//     Console.WriteLine(str);
    for (int i = 0; i < Massiv.Length; i++)
    {
        if (Massiv[i] > min)
        {
           if (Massiv[i] < max)
           {

           }
           else
           {
            max = Massiv[i];
           }
        }
        else 
        {
          min = Massiv[i];
        }

        // Console.WriteLine(min);
        // Console.WriteLine(max);
    }
    if (vuzov)
    {
        return min;
    }
    else
    {
        return max;
    }
}


FillMassiv(Massiv);
min = Massiv[0];
max = Massiv[0];
vuzov = true;
min = Sravnenie(vuzov, Massiv);
vuzov = false;
max = Sravnenie(vuzov, Massiv);
Raznica = max - min;


Console.WriteLine(Raznica);
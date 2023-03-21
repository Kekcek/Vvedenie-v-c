// СЕМИНАР 4.

// Task 1. Наобходимо задачть число и вывести сумму чисел от одного до этого числа.
/*
int GetSumOfNumbers(int number)
{
    int sum = 0;
    for (int current = 0; current <= number; current++) // переменная созданная внутри цикла(current) будет существовать только там
    {
        sum = sum + current;
    }
    return sum;
}

Console.WriteLine("Введите рабочее число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSumOfNumbers(number));
*/

// Task 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int QuantityFigureInNumber(int number)
{
    int counter = 0;
    while (number> 0)
    {
        if (number > 0) 
        {
            counter++;
            number = number / 10;
        }
        else break;
    }
    return counter;
}
Console.WriteLine("Введите рабочее число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(QuantityFigureInNumber(number));
*/

// Task 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factroial(int num)
{
    int result = 1;
    for (int i = 2; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}
Console.WriteLine("Введите рабочее число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factroial(number));
*/

// Массивы
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // new int[размер] - эта констуркция позволяет инициализировать массив

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }

    Console. WriteLine();
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнее значения для чисел массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнее значения для чисел массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, minValue, maxValue);
WriteArray(array);
*/

// СЕМИНАР 5.

// Task 1.Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных элементов массива
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // new int[размер] - эта констуркция позволяет инициализировать массив

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }

    Console. WriteLine();
}

int GetNegativeSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
return sum;
}




Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнее значения для чисел массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнее значения для чисел массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, minValue, maxValue);
WriteArray(array);
int sum = GetNegativeSum(array);
Console.WriteLine(sum);
*/


// Task 2.Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // new int[размер] - эта констуркция позволяет инициализировать массив

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void WriteArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }

    Console. WriteLine();
}

int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }

    return array;
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнее значения для чисел массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнее значения для чисел массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, minValue, maxValue);
WriteArray(array);
Reverse(array);
WriteArray(array);
*/

// Task 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // new int[размер] - эта констуркция позволяет инициализировать массив

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }

    Console. WriteLine();
}

bool SearchNumberInArray(int[] array, int searchNum)
{
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] == searchNum)
            return true;
    }
    return false;
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнее значения для чисел массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнее значения для чисел массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомое число: ");
int searchNum = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, minValue, maxValue);
WriteArray(array);
Console.WriteLine(SearchNumberInArray(array, searchNum));
*/

// Task 4. Задайте одномерный массив из m случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // new int[размер] - эта констуркция позволяет инициализировать массив

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }

    Console. WriteLine();
}

int SearchCounter(int[] array, int a, int b)
{
    int counter = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] >= a && array[index] <= b) counter++;
    }

    return counter;
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнее значения для чисел массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнее значения для чисел массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ограничение снизу: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ограничение сверху: ");
int B = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, minValue, maxValue);
WriteArray(array);
int counter = SearchCounter(array, A, B);
Console.WriteLine(counter);
*/
// Task 5. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // new int[размер] - эта констуркция позволяет инициализировать массив

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }

    Console. WriteLine();
}

int[] MultyArray(int[] array)
{
    int size = 0;
    if (array.Length % 2 == 0)
    {
        size = array.Length / 2;
    }
    else
    {
        size = array.Length / 2 + 1;
    }

    int[] NewArray = new int[size];

    for (int index = 0; index < size; index++)
    {
        NewArray[index] = array[index] * array[array.Length - 1 - index];
    } 
    return NewArray;
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнее значения для чисел массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнее значения для чисел массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[] array = CreateRandomArray(length, minValue, maxValue);
WriteArray(array);

WriteArray(MultyArray(array));

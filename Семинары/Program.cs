// СЕМИНАР 4.
/*
// Task 1. Наобходимо задачть число и вывести сумму чисел от одного до этого числа.

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


// Task 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

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


// Task 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

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


// Массивы

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
/*
// Task 1.Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных элементов массива

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


// Task 2.Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

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

// Task 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

// Task 4. Задайте одномерный массив из m случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

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
*/

// СЕМИНАР 6.

/*

// void ShowNum(int num)
// {
//     num += 5;
//     Console.WriteLine(num); // 
// }

// int num = 5;
// ShowNum(num);
// Console.WriteLine(num);

void ShowNum(int[] num)
{
    num[0] += 5;
    Console.WriteLine(num[0]); // массивы - ссылочный тип данных, именно поэтому когда мы передем массив в функцию, не создается копия, как с числами, а меняется сам массив.
}

int[] array = {1, 2, 3};
ShowNum(array);
Console.WriteLine(array[0]);
*/

// Task 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

void ReverseArray(int[] array)
{
    for(int leftIndex = 0, rightIndex = array.Length - 1; 
    leftIndex < rightIndex; leftIndex++, rightIndex--)
    {
        int temp = array[leftIndex];
        array[leftIndex] = array[rightIndex];
        array[rightIndex] = temp;
    }
}

    Console.Write("Введите размер массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите нижнее значения для чисел массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите верхнее значения для чисел массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());


    int[] array = CreateRandomArray(length, minValue, maxValue);
    WriteArray(array);
    ReverseArray(array);
    WriteArray(array);

*/

// Task 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*

// bool CheckSide(int NumA, int NumB, int NumC)
// {
//     if (NumA < NumB + NumC && NumB < NumA + NumC && NumC< NumA + NumB) return true;
//     return false;

// }

//     Console.Write("Введите сторону A: ");
//     int NumA = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите сторону B: ");
//     int NumB = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите сторону С: ");
//     int NumC = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine(CheckSide(NumA, NumB, NumC));
*/

// Task 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
/*
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

int[] CreateArrayFibonachi(int N, int First, int Second)
{
    int[] Array = new int[N];
    Array[0] = First;
    Array[1] = Second;

    for (int index = 2; index < N; index++)
    {
        Array[index] = Array[index - 1] + Array[index - 2];
    }

    return Array;
}


Console.Write("Введите размер ряда: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число последовательности: ");
int First = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число последовательности: ");
int Second = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayFibonachi(N, First, Second);
WriteArray(array);
*/

// Task 4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
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
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

int[] CopyArray(int[] OldArray)
{
    int[] NewArray = new int[OldArray.Length];
    for (int index = 0; index < OldArray.Length; index++)
    {
        NewArray[index] = OldArray[index];
    }
    return NewArray;
}



Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнее значения для чисел массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнее значения для чисел массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[] OldArray = CreateRandomArray(length, minValue, maxValue);
int[] NewArray = CopyArray(OldArray);
*/

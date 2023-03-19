// // Вид 1 - ничего не возвращают и ничего не принимают
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// Method1(); // - это просто обычный вызов метода(функции)

// Вид 2 - Ничего не возвращают, но имеют аргмуенты
// void Method2(string msg)
// {
//     Console.WriteLine();
// }
// Method2(msg: "Текст сообщения");// это пример именовонного аргумента, мы можем явно указать какое значение, какому аргументу можно задать

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method21(msg: "Текст", count: 4);


//Вид 3 - ничего не принимают, но что-то возвращают. В данной ситуации надо обязательо указать типа данных функции
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

//Вид 4 методов - что-то принимают и что-то возвращают
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "q");
// Console.WriteLine(res);



// string Method4(int count, string c) // тот же пример что и выше, только с использованием for
// {
//     string result = string.Empty;


//     for(int i = 0; i < count; i++)
//     {
//         result = result + c;
//     }
//     return result;
// }
// string res = Method4(count:10, c:"q");
// Console.WriteLine(res);


//Пример задачи вывода таблицы умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.Write($"   {i} * {j} = {i * j}  ");
//     }
//     Console.WriteLine("");
// } 



//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.
/*
string text = "Абра кадабра - величайшее заклизание";
// string s = "qwerty" К символу в строке можно обратиться с помощью индекса. Прям как в массиве
//             012
//s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i<length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'а', 'А');
Console.WriteLine(newText);
*/

// Алгроритм сортировки методом выбора максимального(минимального)
// 6 8 3 2 1 4 5 7
//  <<<<<<<|
// 1 8 3 2 6 4 5 7
// И так далее, то есть неоьходимо найти минимальный элемент и поменять его местами  с текующим.

int[] array = {1, 5, 6, 3, 2, 5, 6, 3, 8, 9, 0};

void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(array);
SelectionSort(array);

PrintArray(array);
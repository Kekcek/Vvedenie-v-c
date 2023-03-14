void FillArray(int[] colletcion) //void - функция которая ничего не возвращает. У нее нет return, поэтому мы ничего из нее не забираем. Проделываем определнные действия, например: вывод чего-то на экран и выходим из функции.
{
    int length = colletcion.Length;
    int index = 0;
    while(index < length)
    {
        colletcion[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(col[position]+ " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if (collection[index] == find)
            {
                position = index;
                break;
            }
        index ++;
    }
    return position;
}

int[] Array = new int[10]; // Создали массив из 10 чисел и заполнили его нулями

FillArray(Array); // Вызываем функцию, чтобы заполнить массив рандомными числами.
PrintArray(Array);// Функция, чтобы вывести наш массив
Console. WriteLine();

int pos = IndexOf(Array, 4);// Обращаемся к функции, которая ишет индекс числа, который мы задаем для поиска
Console. WriteLine(pos);
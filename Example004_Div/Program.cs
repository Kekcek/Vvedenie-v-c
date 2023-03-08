double numberA = new Random().Next(1,10);//1,2,3...9
double numberB = new Random().Next(1,10);

Console.WriteLine(numberA);
Console.WriteLine(numberB);
Console.WriteLine(numberA / numberB);
//new Random().Next(min, max) - создает случайное число в указанном диапозоне, причем max будет на 1 меньше, то есть если укажем 10, то будет число 9
// Диапазон можно задать по разному [min, max-1][min, max)
﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;

    return result;
}

// int a1 = 10;
// int b1 = 15;
// int c1 = 40;
// int a2 = 13;
// int b2 = 2233;
// int c2 = 33;
// int a3 = 17;
// int b3 = 232444;
// int c3 = 313;

// В первом варианты использовали создание многих переменных. Сейчас заменимм этот способ на создание массива

int[] array = {11, 24, 32, 45, 5216, 76, 27, 88, 49};

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);

// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);
// int max = Max(max1,max2,max3);

// int max = Max(
//     Max(a1,b1,c1),
//     Max(a2,b2,c2),
//     Max(a3,b3,c3));


// Console.WriteLine(max);
﻿int a = 1;
int b = 2;
int c = 6;
int d = 4;
int e = 8;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Наибольшее число: ");
Console.WriteLine(max);
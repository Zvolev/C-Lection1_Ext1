﻿int a = 5;
int b = 4;
int c = 7;
int d = 8;
int e = 3;

int max = a;

if (b>max) max = b;
if (c>max) max = c;
if (d>max) max = d;
if (e>max) max = e;

Console.Write("max = ");
Console.WriteLine(max);
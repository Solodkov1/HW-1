// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = -9; 
int b = -3;
int max = a;

if (a > b) max = a;
if (a < b) max = b;
Console.Write("max= ");
Console.WriteLine(max);


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a2 = 10; 
int b2 = 15;
int c2 = -3;
int max2 = a2;

if (a2 > b2) 
{
    if (a2 > c2) max2 = a2;
}
if (b2 > a2)
{
    if (b2 > c2) max2 = b2;
}
if (c2 > a2)
{
    if (c2 > b2) max2 = c2;
}
Console.Write("max2= ");
Console.WriteLine(max2);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int a3 = -3;

if (a3 % 2 == 0) Console.WriteLine("Чётное");
else Console.WriteLine("Не чётное");


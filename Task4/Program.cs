//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число n= ");

int n = Convert.ToInt32(Console.ReadLine());

int numbers = 2;

Console.WriteLine("Чётные числа ");

while (numbers <= n) // в задачи небыло уточнения по поводу N включительно или нет, поэтому включил
{
     Console.Write(numbers); Console.Write(", ");
    numbers = numbers + 2;
}
    
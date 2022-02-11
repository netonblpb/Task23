// Показать таблицу квадратов чисел от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int i = 1;
int step = 1;
while (i < num +1)
{
    //step = i*i*i;
    Console.Write($"{i} в квадрате степени равно {Math.Pow(i, 2)}");
    Console.WriteLine();
    i++;
}
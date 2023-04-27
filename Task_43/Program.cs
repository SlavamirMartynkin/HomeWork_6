//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//k1 * x + b1 = k2 * x + b2
//k1 * x - k2 * x = b2 - b1

//x = (b2 - b1) / (k1 - k2)
//y = k1 * x + b1
//y = k2 * x + b2

int ReadInt(string argument) // проверка на число
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число!");
        Console.Write(argument);
    }
    return i;
}

double[] KrossPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    //double y = k1 * x + b1;
    double y = k2 * x + b2;
    double[] array = new double [2];
    array[0] = x;
    array[1] = y;
    return array;
}

int b1 = ReadInt("Введите b1: ");
int k1 = ReadInt("Введите k1: ");
int b2 = ReadInt("Введите b2: ");
int k2 = ReadInt("Введите k2: ");

System.Console.WriteLine($"[{string.Join(",", KrossPoint(b1, k1, b2, k2))}]");
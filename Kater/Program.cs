//катер плывет против течения из пункта А в пункт Б
//v1 - скорость течения известна
//v2 - скорость катера известна
//L - расстояние(А - Б) известно
//Необходимо узнмть время t за которое катер доберется до пункта Б
// v = L / t  =>  t = 

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

void FindTime(double speed_boat, double speed_river, double distance)
{
    double time = distance / (speed_boat - speed_river);
    double min = time * 60 % 60;
    System.Console.WriteLine($"Катер преодолеет расстояние за {Math.Round(time, 0)} часа(ов) {Math.Round(min, 0)} минут(ы)");
}

double speed_river = ReadInt("Укажите скорость реки (км/ч): ");
double speed_boat = ReadInt("Укажите скорость катера (км/ч): ");
double distance = ReadInt("укажите расстояние между городами (км): ");
FindTime(speed_boat, speed_river, distance);
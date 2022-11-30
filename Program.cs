//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.Clear();
int DataEntryXYZ(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double CalcDistance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt ((Math.Pow((x2-x1),2))+(Math.Pow((y2-y1),2))+(Math.Pow((z2-z1),2)));
    return result;
}

int x1 = DataEntryXYZ("Введите координаты первой точки по оси x: ");
int y1 = DataEntryXYZ("Введите координаты первой точки по оси y: ");
int z1 = DataEntryXYZ("Введите координаты первой точки по оси z: ");
int x2 = DataEntryXYZ("Введите координаты второй точки по оси x: ");
int y2 = DataEntryXYZ("Введите координаты второй точки по оси y: ");
int z2 = DataEntryXYZ("Введите координаты второй точки по оси z: ");

double result = CalcDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между данными точками равно " + result);
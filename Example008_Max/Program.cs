// Максимум из 9 чисел
int Max(int args1, int args2, int args3)
{
    int result = 0;
    if (args1 > result) result = args1;
    if (args2 > result) result = args2;
    if (args3 > result) result = args3;
    return result;
}

int GetData()
{
    Console.Write("Введите значение: ");
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetData();
int b = GetData();
int c = GetData();
int d = GetData();
int e = GetData();
int f = GetData();
int g = GetData();
int h = GetData();
int i = GetData();

int max1 = Max(a, b, c);
int max2 = Max(d, e, f);
int max3 = Max(g, h, i);

int max = Max(max1, max2, max3);

Console.Write("Максимальное число:  ");
Console.WriteLine(max);
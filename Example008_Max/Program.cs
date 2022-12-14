// Максимум из 9 чисел

// Вариант 1 
//Console.Write("Введите значение: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите значение: ");
//int b = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите значение: ");
//int c = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите значение: ");
//int d = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите значение: ");
//int e = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите значение: ");
//int f = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите значение: ");
//int g = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите значение: ");
//int h = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите значение: ");
//int i = Convert.ToInt32(Console.ReadLine());

//int max = a;

//if (max < b) max = b;
//if (max < c) max = c;
//if (max < d) max = d;
//if (max < e) max = e;
//if (max < f) max = f;
//if (max < g) max = g;
//if (max < h) max = h;
//if (max < i) max = i;

//Console.Write("max = ");
//Console.Write(max);

// Вариант 2

//int Max(int args1, int args2, int args3)
//{
//    int result = 0;
//    if (args1 > result) result = args1;
//    if (args2 > result) result = args2;
//    if (args3 > result) result = args3;
//    return result;
//}

//int GetData()
//{
//    Console.Write("Введите значение: ");
//    return Convert.ToInt32(Console.ReadLine());
//}

//int a = GetData();
//int b = GetData();
//int c = GetData();
//int d = GetData();
//int e = GetData();
//int f = GetData();
//int g = GetData();
//int h = GetData();
//int i = GetData();

//int max1 = Max(a, b, c);
//int max2 = Max(d, e, f);
//int max3 = Max(g, h, i);

//int max = Max(max1, max2, max3);

//Console.Write("Максимальное число:  ");
//Console.WriteLine(max);

// Вариант 3

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

int max = Max(
                 Max(GetData(), GetData(), GetData()),
                 Max(GetData(), GetData(), GetData()),
                 Max(GetData(), GetData(), GetData())
              );
              
Console.Write("Максимальное число:  ");
Console.WriteLine(max);
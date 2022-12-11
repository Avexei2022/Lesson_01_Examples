// Задача про точки в треугольнике
Console.Clear(); // Очитска терминала
// Console.SetCursorPosition(10,4); // Установка курсора с отступом слева и сверху
// Console.WriteLine("+");
int ax = 60; // вершина a отступ по x 
int ay = 1; // вершина a отступ по y
int bx = 1; // вершина b отступ по x
int by = 30; // вершина b отступ по y
// возможный компактный вариант записи int xa = 1, ya = 1, xb = 1, yb =30
int cx = 120; //вершина c отступ по x & y
int cy = 30; // вершина c отступ по x & y
Console.SetCursorPosition(ax,ay);
Console.Write("+");
Console.SetCursorPosition(bx,by);
Console.Write("+");
Console.SetCursorPosition(cx,cy);
Console.Write("+");
int x = ax, y = ay;
int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = ((x + ax) / 2) + ((x + ax) % 2);
        y = ((y + ay) / 2) + ((y + ay) % 2);
    }
    if (what == 1)
    {
        x = ((x + bx) / 2) + ((x + bx) % 2);
        y = ((y + by) / 2) + ((y + by) % 2);
    }
    if (what == 2)
    {
        x = ((x + cx) / 2) + ((x + cx) % 2);
        y = ((y + cy) / 2) + ((y + cy) % 2);
    }
    
    Console.SetCursorPosition(x, y);
    Console.Write("+"); 
    count++;
}
Console.SetCursorPosition(0,34); //устанавливаем курсор ниже треугольника
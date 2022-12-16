// Friends & dog
// Чистим терминал
Console.Clear(); 

// Выводим на экран условия задачи
Console.WriteLine("Задача про друзей и собаку.");
Console.WriteLine("Два друга идут навстречу друг другу, а собака бегает между друзями.");
Console.WriteLine("Сколько раз собака пробежит между друзьями если известны:");
Console.WriteLine("расстояние между друзьями, скорость движения друзей и скорость движения собаки?");
Console.WriteLine(""); // Отделяем пустой строкой условия задачи

// Просим ввести значения расстояния между друзьями и проверяем его на соответствие условиям
Console.Write("Введите расстояние между друзьями в метрах (не менее 10 и не более 10000): ");
double distance = 0;
double.TryParse(Console.ReadLine(), out distance);
while (distance < 10 | distance > 10000)
{
    Console.WriteLine("Вы не выполнили условия!");
    Console.Write("Повторите ввод: ");
    double.TryParse(Console.ReadLine(), out distance);
}
Console.WriteLine(""); // Отделяем пустой строкой условия

// Просим ввести значение скорости движения первого друга и проверяем его на соответствие условиям
Console.Write("Введите скорость движения первого друга в км/ч (от 1 до 10): ");
double first_friend_speed = 0;
double.TryParse(Console.ReadLine(), out first_friend_speed);
while (first_friend_speed < 1 | first_friend_speed > 10)
{
    Console.WriteLine("Это неадекватная скорость движения человека, гуляющего с собакой!");
    Console.Write("Повторите ввод: ");
    double.TryParse(Console.ReadLine(), out first_friend_speed);
}
Console.WriteLine(""); // Отделяем пустой строкой условия

// Просим ввести значение скорости движения второго друга и проверяем его на соответствие условиям
Console.Write("Введите скорость движения второго друга в км/ч (от 1 до 10): ");
double second_friend_speed = 0;
double.TryParse(Console.ReadLine(), out second_friend_speed);
while (second_friend_speed < 1 | second_friend_speed > 10)
{
    Console.WriteLine("Это неадекватная скорость движения человека, гуляющего с собакой!");
    Console.Write("Повторите ввод: ");
    double.TryParse(Console.ReadLine(), out second_friend_speed);
}
Console.WriteLine(""); // Отделяем пустой строкой условия

// Просим ввести значение скорости собаки и проверяем его на соответствие условиям
Console.Write("Введите скорость движения собаки в км/ч (до 30, но не меньше скорости каждого из друзей ): ");
double dog_speed = 0;
double.TryParse(Console.ReadLine(), out dog_speed);
while (dog_speed < first_friend_speed | dog_speed < second_friend_speed | dog_speed > 30)
{
    Console.WriteLine("Пусть песик побегает с нормальной скоростью!");
    Console.Write("Повторите ввод: ");
    double.TryParse(Console.ReadLine(), out dog_speed);
}
Console.WriteLine(""); // Отделяем пустой строкой условия

// Просим ввести первоначальное направление движения собаки и проверяем выполение условий ввода
Console.WriteLine("По напрвлению к какому другу бежит собака?");
Console.Write("Введите цифры 1 или 2: ");
int friend_direction = 2;
int.TryParse(Console.ReadLine(), out friend_direction);
while (friend_direction < 1 | friend_direction > 2)
{
    Console.WriteLine("Такого друга в условии задачи нет!");
    Console.Write("Повторите ввод: ");
    int.TryParse(Console.ReadLine(), out friend_direction);
}
Console.WriteLine(""); // Отделяем пустой строкой условия

// Просим ввести минимальное расстояние между друзьями
Console.WriteLine("При каком минимальном расстоянии между друзьями собака прекратит бегать?");
Console.Write("Введите значение (не менее 10 и не более расстояния между друзьями): ");
double distance_stop = 0;
double.TryParse(Console.ReadLine(), out distance_stop);
while (distance_stop < 10 | distance_stop > distance) 
{
    Console.WriteLine("Вы не выполнили условия!");
    Console.Write("Повторите ввод: ");
    double.TryParse(Console.ReadLine(), out distance_stop);
}
Console.WriteLine(""); // Отделяем пустой строкой условия

// Конвертируем скорость из км/ч в м/с
first_friend_speed = first_friend_speed * 1000 / 3600;
second_friend_speed = second_friend_speed * 1000 / 3600;
dog_speed = dog_speed * 1000 / 3600;

// устанавливаем счетчик на 0
int count = 0; // счетчик количества пробежек собаки
double time = 0; // счетчик времени

Console.WriteLine("");
// Решаем задачу
while(distance > distance_stop) // выполняем программу до тех пор, пока расстояние между друзьями не достигнет минимального
                                // расстояния, установленного при вводе данных
{
    if (friend_direction == 1) // Если собака бежит в сторону первого друга
    {
      time = distance / (first_friend_speed + dog_speed); // считаем истекшее время встречи друга и собаки 
      friend_direction = 2;
    }
    else
    {
      time = distance / (second_friend_speed + dog_speed); // считаем истекшее время встречи друга и собаки 
      friend_direction = 1;
    }
    distance = distance - (first_friend_speed + second_friend_speed) * time; // считаем оставшееся расстояние между друзьями
    if (distance > distance_stop) // проверяем оставшееся расстояние между друзьями на соответствие минимальному расстоянию стопа программы
    { // и если рассотяние больше расстояния стопа вычислений
        count++; // увеличиваем счетчик на 1, как свершившийся факт пробежки собаки между друзьями
        Console.Write("Собака добежит до друга "); // выводим на экран промежуточные результаты:
        if (friend_direction == 1) Console.Write("2"); 
        else Console.Write("1");
        Console.Write(" за ");
 //       Console.Write(time); // - время пробежки собаки от друга до друга
 //       Console.Write((time).ToString("#,##")); // - время пробежки собаки от друга до другa конвертированное в строку
        Console.Write(Math.Round(time, 1)); // - время пробежки собаки от друга до другa округленное до 0,1
        Console.WriteLine(" секунд ");
        Console.Write("Между друзьями осталось "); 
 //       Console.Write(distance);  // - оставшееся расстояние между друзьями
 //       Console.Write((distance).ToString("#,##")); // - оставшееся расстояние между друзьями конвертированное в строку
        Console.Write(Math.Round(distance, 2)); // оставшееся расстояние между друзьями округленное до 0,01
        Console.WriteLine(" метров ");
        Console.WriteLine("");  
    } 
    else // если оставшееся расстояние между друзьями маньше расстояния стопа вычислений
    {
        distance = distance + (first_friend_speed + second_friend_speed) * time; // возвращаемся к расстоянию между друзьями еще соотетствующему условиям
        time = (distance - distance_stop) / (first_friend_speed + second_friend_speed); // вычисляем время до стопа вычислений  
        if (friend_direction == 1) distance = distance - (first_friend_speed + dog_speed) * time; // вычисляем оставшееся расстояние между собакой и другом
        else distance = distance - (second_friend_speed + dog_speed) * time;
        Console.Write("При расстоянии между друзьями ");
        Console.Write(distance_stop);
        Console.WriteLine(" метров");
        Console.Write("собака не добежит до друга "); // выводим на экран оставшееся расстояние между собакой и другом
        if (friend_direction == 1) Console.Write("2 - ");
        else Console.Write("1 - ");
 //       Console.Write(distance);
 //       Console.Write((distance).ToString("#,##"));
        Console.Write(Math.Round(distance, 2)); // оставшееся расстояние между собакой и другом округленное до 0,01
        Console.WriteLine(" метров ");
        Console.Write("при этом ");  
    }
    }

 // Выводим результат   
Console.Write("собака пробежит между друзьями ");
Console.Write(count);
Console.WriteLine(" раз.");
Console.WriteLine("");  
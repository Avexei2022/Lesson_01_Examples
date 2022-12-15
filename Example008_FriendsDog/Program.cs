// Friends & dog
// Чистим терминал
Console.Clear(); 

// Выводим на экран условия задачи
Console.WriteLine("Задача про друзей и собаку.");
Console.WriteLine("Два друга идут навстречу друг другу, а собака бегает между друзями.");
Console.WriteLine("Сколько раз собака пробежит между друзьями если известны:");
Console.WriteLine("расстояние между друзьями, скорость движения друзей и скорость движения собаки?");

// Просим ввести значения расстояния между друзьями и проверяем его на соответствие условиям
Console.Write("Введите расстояние между друзьями в метрах (не менее 10 и не более 10000): ");
double distance = 0;
double.TryParse(Console.ReadLine(), out distance);
while (distance < 10 | distance > 10000)
{
    Console.WriteLine("Вы не выполнили условия!");
    Console.Write("Повторите ввод:");
    double.TryParse(Console.ReadLine(), out distance);
}

// Просим ввести значение скорости движения первого друга и проверяем его на соответствие условиям
Console.Write("Введите скорость движения первого друга в км/ч (от 1 до 10): ");
double first_friend_speed = 0;
double.TryParse(Console.ReadLine(), out first_friend_speed);
while (first_friend_speed < 1 | first_friend_speed > 10)
{
    Console.WriteLine("Это неадекватная скорость движения человека, гуляющего с собакой!");
    Console.Write("Повторите ввод:");
    double.TryParse(Console.ReadLine(), out first_friend_speed);
}
// Просим ввести значение скорости движения второго друга и проверяем его на соответствие условиям
Console.Write("Введите скорость движения второго друга в км/ч (от 1 до 10): ");
double second_friend_speed = 0;
double.TryParse(Console.ReadLine(), out second_friend_speed);
while (second_friend_speed < 1 | second_friend_speed > 10)
{
    Console.WriteLine("Это неадекватная скорость движения человека, гуляющего с собакой!");
    Console.Write("Повторите ввод:");
    double.TryParse(Console.ReadLine(), out second_friend_speed);
}

// Просим ввести значение скорости собаки и проверяем его на соответствие условиям
Console.Write("Введите скорость движения собаки в км/ч (от 1 до 30): ");
double dog_speed = 0;
double.TryParse(Console.ReadLine(), out dog_speed);
while (dog_speed < 1 | dog_speed > 30)
{
    Console.WriteLine("Пусть песик побегает с нормальной скоростью!");
    Console.Write("Повторите ввод:");
    double.TryParse(Console.ReadLine(), out dog_speed);
}

// Просим ввести первоначальное направление движения собаки
Console.WriteLine("По напрвлению к какому другу бежит собака?");
Console.Write("Введите цифры 1 или 2:");
int friend_direction = 2;
int.TryParse(Console.ReadLine(), out friend_direction);
while (friend_direction < 1 | friend_direction > 2)
{
    Console.WriteLine("Такого друга в условии задачи нет!");
    Console.Write("Повторите ввод:");
    int.TryParse(Console.ReadLine(), out friend_direction);
}

// Просим ввести минимальное расстояние между друзьями
Console.WriteLine("При каком минимальном расстоянии между друзьями собака прекратит бегать?");
Console.Write("Введите значение (не менее 10 и не более расстояния между друзьями):");
double distance_stop = 0;
double.TryParse(Console.ReadLine(), out distance_stop);
while (distance_stop < 10 | distance_stop > distance)
{
    Console.WriteLine("Вы не выполнили условия!");
    Console.Write("Повторите ввод:");
    double.TryParse(Console.ReadLine(), out distance_stop);
}

// Конвертируем скорость из км/ч в м/с
first_friend_speed = first_friend_speed * 1000 / 3600;
second_friend_speed = second_friend_speed * 1000 / 3600;
dog_speed = dog_speed * 1000 / 3600;

// устанавливаем счетчик на 0
int count = 0;
double time = 0;

Console.WriteLine("");
// Решаем задачу
while(distance > distance_stop)
{
    if (friend_direction == 1)
    {
      time = distance / (first_friend_speed + dog_speed);
      Console.Write("Собака добежит до друга ");
      Console.Write(friend_direction);
      Console.Write(" за ");
      Console.Write(time);
      Console.WriteLine(" секунд ");
      friend_direction = 2;
    }
    else
    {
      time = distance / (second_friend_speed + dog_speed);
      Console.Write("Собака добежит до друга ");
      Console.Write(friend_direction);
      Console.Write(" за ");
      Console.Write(time);
      Console.WriteLine(" секунд ");
      friend_direction = 1;
    }
    distance = distance - (first_friend_speed + second_friend_speed) * time;
    Console.Write("Между друзьями осталось ");
    Console.Write(distance);
    Console.WriteLine(" метров ");
    if (distance > distance_stop) count++;
    }
Console.WriteLine("");  
Console.Write("Собака пробежит между друзьями ");
Console.Write(count);
Console.WriteLine(" раз.");
Console.WriteLine("");  
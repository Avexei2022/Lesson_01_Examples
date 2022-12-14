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
double distance = Convert.ToDouble(Console.ReadLine());
if (distance < 10 | distance > 10000)
{
    while (distance < 10 | distance > 10000)
    {
        Console.WriteLine("Вы не выполнили условия!");
        Console.Write("Повторите ввод:");
        distance = Convert.ToDouble(Console.ReadLine());
    }
}

// Просим ввести значение скорости движения первого друга и проверяем его на соответствие условиям
Console.Write("Введите скорость движения первого друга в км/ч: ");
int first_friend_speed = Convert.ToInt32(Console.ReadLine());
if (first_friend_speed < 1 | first_friend_speed > 10)
{
    while (first_friend_speed < 1 | first_friend_speed > 10)
    {
        Console.WriteLine("Это неадекватная скорость движения человека, гуляющего с собакой!");
        Console.Write("Повторите ввод:");
        first_friend_speed = Convert.ToInt32(Console.ReadLine());
    }
}

// Просим ввести значение скорости движения второго друга и проверяем его на соответствие условиям
Console.Write("Введите скорость движения второго друга в км/ч: ");
int second_friend_speed = Convert.ToInt32(Console.ReadLine());
if (second_friend_speed < 1 | second_friend_speed > 10)
{
    while (second_friend_speed < 1 | second_friend_speed > 10)
    {
        Console.WriteLine("Это неадекватная скорость движения человека, гуляющего с собакой!");
        Console.Write("Повторите ввод:");
        second_friend_speed = Convert.ToInt32(Console.ReadLine());
    }
}

// Просим ввести значение скорости собаки и проверяем его на соответствие условиям
Console.Write("Введите скорость движения собаки в км/ч: ");
int dog_speed = Convert.ToInt32(Console.ReadLine());
if (dog_speed < 1 | dog_speed > 30)
{
    while (dog_speed < 1 | dog_speed > 30)
    {
        Console.WriteLine("Пусть песик побегает с нормальной скоростью!");
        Console.Write("Повторите ввод:");
        dog_speed = Convert.ToInt32(Console.ReadLine());
    }
}

// Просим ввести первоначальное направление движения собаки
Console.WriteLine("По напрвлению к какому другу бежит собака?");
Console.Write("Введите цифры 1 или 2:");
int friend_direction = Convert.ToInt32(Console.ReadLine());
if (friend_direction < 1 | friend_direction > 2)
{
    while (friend_direction < 1 | friend_direction > 2)
    {
        Console.WriteLine("Такого друга в условии задачи нет!");
        Console.Write("Повторите ввод:");
        friend_direction = Convert.ToInt32(Console.ReadLine());
    }
}

// Просим ввести минимальное расстояние между друзьями
Console.WriteLine("При каком минимальном расстоянии между друзьями собака прекратит бегать?");
Console.Write("Введите значение (не менее 10 и не более расстояния между друзьями):");
double distance_stop = Convert.ToDouble(Console.ReadLine());
if (distance_stop < 10 | distance_stop > distance)
{
    while (distance_stop < 10 | distance_stop > distance)
    {
        Console.WriteLine("Вы не выполнили условия!");
        Console.Write("Повторите ввод:");
        distance_stop = Convert.ToDouble(Console.ReadLine());
    }
}

// Конвертируем скорость из км/ч в м/с
first_friend_speed = first_friend_speed * 1000 / 3600;
second_friend_speed = second_friend_speed * 1000 / 3600;
dog_speed = dog_speed * 1000 / 3600;

// устанавливаем счетчик на 0
int count = 0;
double time = 0;

// Решаем задачу
while(distance > distance_stop)
{
    if (friend_direction == 1)
    {
      time = distance / (first_friend_speed + dog_speed);
      friend_direction = 2;
    }
    if (friend_direction == 2)
    {
      time = distance / (second_friend_speed + dog_speed);
      friend_direction = 1;
    }
    distance = distance - (first_friend_speed + second_friend_speed) * time;
    count = count + 1;
}
  
Console.Write("Собака пробежит между друзьями ");
Console.Write(count);
Console.WriteLine(" раз.");
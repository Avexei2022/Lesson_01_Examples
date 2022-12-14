// Работаем с массивом
int [] array = {11, 21, 31, 41, 15, 61, 17, 18, 91};

// Выводим на экран значение первого числа в массие
Console.WriteLine(array[0]);

// Меняем значение первого числа и выводим на экран
array[0] = 12;
Console.WriteLine(array[0]);

// Выводим на экран значение 5-го элемента 
Console.WriteLine(array[4]);


int array_size = 9;
int index = 1;
int max = array[0];
while(index < array_size)
{
    if (array[index] > max) max = array[index];
    index ++;
}
Console.Write("Максимальное число в массие: ");
Console.WriteLine(max);
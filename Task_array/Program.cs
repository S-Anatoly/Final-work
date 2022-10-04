Console.Clear();
Console.WriteLine("Массив из элементов, длина которых меньше или равна трем символам.");

Console.Write("Введите количество строк, которые хотите ввести: ");
int arrayLength = int.Parse(Console.ReadLine()); // Водим длину массива.

if (arrayLength <= 0) //Проверка вводимой длины массива
{
    Console.WriteLine("Вы ввели не корректную длину массива!");
    return;
}

string[] array = new string[arrayLength]; //Объявляем массив строк длиной n (которую ввёл пользователь)

for (int i = 0; i < arrayLength; i++)   //Заполняем массив с клавиатуры
{
    Console.Write($"Введите {i + 1} строку:\r\n ");
    array[i] = Console.ReadLine(); 
}

Console.Write("Ваш массив: "); 
for (int i = 0; i < arrayLength; i++)   //Выводим массив на экран
{
    Console.Write(array[i] + ", ");
}
Console.WriteLine();

Console.Write("Массив из значений, состоящий из трех или меньше символов:  ");
for (int i = 0; i < arrayLength; i++)   //Выводим новый массив из элементов., длина которых меньше 3 символов
{
    if (array[i].Length <= 3)
    {
        Console.Write(array[i] + ", ");
    }
}

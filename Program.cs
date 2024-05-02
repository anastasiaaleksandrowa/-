// Задача: Написать программу, которая из имеющегося массива
//  строк формирует новый массив из строк, длина которых меньше, 
//  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//   лучше обойтись исключительно массивами.


// 1. создаем  метод для разделения введенной строки из консоли в элементы массива
string[] ArrayStringConsole (string inConsolSimvol)
{
    string[] arraySimvol = new string[inConsolSimvol.Length];
    arraySimvol = inConsolSimvol.Split(",");
    return arraySimvol;
}
// 2. создаем метод позволяющий проверить длину элеметов массива,
//  все что подходят условию длина меньше, либо равна 3 символам, 
//  считаем для определения длинны нового массива.

string[] ArrayCondition (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            count++;
        }
    }

   // 3. Создаем новый массив из элементов удовлетворяющих условию.

    string[] ArrayCondition = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            ArrayCondition[j] = simvol;
            j++;
        }
    }
    return ArrayCondition;
}
// 4. создаем метод для вывода информации из массивов.

void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Write("Введите набор символов через знак (,) - ");
string inStringSimvol = Console.ReadLine()!;
string[] arraySimvol = ArrayStringConsole(inStringSimvol);
Console.WriteLine();
Console.Write("Введенные символы - ");
Print(arraySimvol);
Console.WriteLine();
Console.Write("Введенные символы длинной меньше либо равны 3 - ");
Print(ArrayCondition(arraySimvol));
Console.WriteLine();
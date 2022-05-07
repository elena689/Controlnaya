// 1. Заполнить строковый массив.
// 2. Выделить элементы массива длина которых меньше либо равна 3.
// 3. Записать в новый результирующий массив получившиеся элементы.
// 4. Вывести на экран новый массив.

string [] CreateTextArray (int length)
{
    string [] textArray = new string [length]; 
    for (int i = 0; i < length; i++)
    {
       Console.Write("Введите слово: ");
       textArray[i] = Convert.ToString(Console.ReadLine()); 
    }
    return textArray;    
}

void PrintArray(string[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}


int length = 5;
string [] text = CreateTextArray(length);
Console.WriteLine();
PrintArray(text);
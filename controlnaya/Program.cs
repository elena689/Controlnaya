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

string [] SearchRowFrom3Symbols (string [] text)
{
    string [] result = new string [text.Length];
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length<=3)
        {
            result[count] = text [i];
            count++;
        }
    }
    return result;
}

void PrintArray(string[] array) 
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] != null)
        {
        Console.Write($"{array[i]} ");
        }
    }
}


int length = new Random().Next(2,6);
string [] text = CreateTextArray(length);
Console.WriteLine("Входной массив:");
PrintArray(text);
string [] resultArray = SearchRowFrom3Symbols(text);
Console.WriteLine();
Console.WriteLine("Массив из строк с количеством символов 3 и менее:");
PrintArray(resultArray);

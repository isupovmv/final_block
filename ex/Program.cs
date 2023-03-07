//из всех элемонтов массива выбрать все, которые меньше 3х символов
Console.Clear();

Console.WriteLine("Введите число элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = FillArray(size);

Console.WriteLine($"Оригинальный массив:    [ {string.Join(", ", array)} ]");

string[] f_array = FinalArray(array);

Console.WriteLine($"Итоговый массив: [ {string.Join(", ", f_array)} ]");


string[] FinalArray(string[] arr)
{
    string[] resultArray = new string[arr.Length];
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            resultArray[j] = arr[i];
            j = j +1;
    }
    return resultArray;
}


string[] FillArray(int sizeArray)
{
    string[] resultArray = new string[sizeArray];
    string temp_s = "";

    for (int i = 0; i < resultArray.Length; i++)
    {
        Console.WriteLine("Введите элемент массива : ");
        temp_s = Console.ReadLine();

        resultArray[i] = temp_s;
    }
    return resultArray;
}
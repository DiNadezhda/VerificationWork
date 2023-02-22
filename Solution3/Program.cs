// 3 вариант решения задачи

string[] array = ArrayInput(3);
Console.WriteLine();
PrintArray(array);

Console.Write(" -> ");
string[] array3 = СreatingNewArray(array, 3);
PrintArray(array3);

//Метод для ввода массива с клавиатуры
string[] ArrayInput(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} слово: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

//Метод, создающий массив из элементов определенной длины
string[] СreatingNewArray(string[] arr, int letters)
{
    //Определяем длину нового массива
    // string[] arrLimit = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= letters && arr[i].Length != 0) j++;
    }
    
    //Формируем новый массив
    string[] arrResult = new string[j];
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= letters) 
        {
            arrResult[k] = arr[i];
            k++;
        }
    }
    return arrResult;
}

//Метод печати массива
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}
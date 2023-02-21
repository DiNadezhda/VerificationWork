/* Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 симовола.
Первоначальный массив можно вывести с клавиатуры, либо задать на старте выполнения алгоритма.

["hello", "2", world", ":-)"]->["2", ":-)"]
["1234", "1567", "-2", "computer science"]->["-2"]
["Russia", "Denmark", "Kazan"]->[] */

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
    string[] arrLimit = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= letters) arrLimit[i] = arr[i];
    }
    return arrLimit;
}

//Метод печати массива
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1 && arr[i] != null) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}
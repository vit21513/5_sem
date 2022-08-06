//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateArrayRndInd (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}


int EventNumArray (int[] array)
{   
    int evenNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenNum = evenNum + 1;
        }
    }
    return evenNum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
    }


int[] array = CreateArrayRndInd(12, 99, 999);
PrintArray(array);
Console.WriteLine();
int result = EventNumArray (array);
Console.WriteLine($" количество чётных чисел в массиве составляет {result} ");




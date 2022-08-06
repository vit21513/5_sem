//Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.


double[] CreateArrayRndDouble(int size, int len)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * len, 1);
    }
    return arr;
}

double DifferenMaxMin(double[] array)
{
    double maxAr = array[0];
    double minAr = array[0];
    double deff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxAr)
        {
            maxAr = array[i];
        }
        if (array[i] < minAr)
        {
            minAr = array[i];
        }

    }
     
    deff = maxAr - minAr;
    return deff;
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + "| ");
        else Console.Write(array[i] + "]");
    }
}

double[] array = CreateArrayRndDouble(5, 10);
PrintArray(array);
Console.WriteLine();
double result = Math.Round(DifferenMaxMin(array), 1);
Console.WriteLine($" разница между максимальным иминимальным элементов массива  составляет {result} ");


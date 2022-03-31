/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
Console.Clear();

Console.Write("Введите количество элементов массива: ");

int N = Convert.ToInt32(Console.ReadLine());

double[] array = new double[N];


double min = 0;
double max = 0;
double diff = 0;
Console.WriteLine("Введите элементы массива: ");
for (int i = 0; i<N; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
    min = array[i];
    if(array[i]>max)
    {
        max = array[i];
    }

    if(array[i]<min)
    {
        min = array[i];
    }
    
    diff = max - min;

}
Console.WriteLine("\nРазница между максимальным ({0}) и минимальным ({1}) элементом массива равна {2}", Math.Round(max,2), Math.Round(min,2), Math.Round(diff,2));
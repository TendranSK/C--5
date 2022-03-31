/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
Console.Write("Введите количетсво элементов массива: ");
int valueOfEllements = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int[] array = new int[valueOfEllements];
int temp = 0;
Console.Write("Количество положительные чисел в массиве:\n[");
for (int i = 0; i<valueOfEllements; i++)
{
    
    array[i]=rand.Next(100,999);
    if(array[i]%2==0)
    {
        temp++;
    }
    if(i == valueOfEllements-1)
    {
        Console.Write(array[i]);
    }
    else
    {
        Console.Write(array[i] + ", ");
    }
}
Console.Write("] - {0}\n",temp);





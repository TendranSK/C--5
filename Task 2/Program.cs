/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Clear();

Console.Write("Введите количетсво элементов массива: ");

int valueOfEllements = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

int[] array = new int[valueOfEllements];

int temp = 0;

Console.Write("Сумма нечетных позиций в массиве:\n[");

for (int i = 0; i<valueOfEllements; i++)
{
    
    array[i]=rand.Next(-100,100);                 //можно поставить любое число, а можно сделать ввод 2х переменных
    if(i%2!=0)                                  // a[0] - не учитывается, т.к. 0 более четное число.
    {
        temp+=array[i];
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
Console.Write("] равна  {0}\n",temp);
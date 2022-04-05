// Задайте двумерный массив. Введите элемент, и найдите первое 
// его вхождение, выведите позиции по горизонтали и вертикали, 
//или напишите, что такого элемента нет.
int[,] array = FillArray(Prompt("Введите количество строк => "), Prompt("Введите количество столбцов => "));
PrintArray(array);
int number = Prompt("Введите элемент => ");
FindElementFirstEntrance(array);
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 20);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FindElementFirstEntrance(int[,] array)
{
    int Count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number == array[i, j])
            {
                Console.WriteLine($"Позиция по горизонтали {i + 1}, по вертикали {j + 1}");
                Count = 1;
                break;
            }
            if (Count == 1)
                break;
        }
    }
    if (Count == 0)
    {
        Console.WriteLine($"Введенного элемента {number} нет в данном массиве");
    }
}



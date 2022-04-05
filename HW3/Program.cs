// Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце и каждой строке.
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
            array[i, j] = i - j;
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

double[] ArithmeticMeanColumn(int[,] array)
{
    double[] arrColumn = new double[array.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        arrColumn[j] = sum / array.GetLength(0);
        sum = 0;
    }
    return arrColumn;
}
double[] ArithmeticMeanRow(int[,] array)
{
    double[] arrRow = new double[array.GetLength(0)];
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        arrRow[i] = sum / array.GetLength(1);
        sum = 0;
    }
    return arrRow;
}

void PrintArr(double[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write($"{collect[i]:0.00}, ");

    }
    Console.Write($"{collect[collect.Length - 1]:0.00}]");
}

int[,] array = FillArray(Prompt("Введите количество строк => "), Prompt("Введите количество столбцов => "));
PrintArray(array);
double[] arrColumn=ArithmeticMeanColumn(array);
double[] arrRow=ArithmeticMeanRow(array);
Console.WriteLine("Среднее арифметическое столбцов");
PrintArr(arrColumn);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое строк");
PrintArr(arrRow);
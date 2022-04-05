// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
int[,] array=FillArray(5,4);
PrintArray(array);
int numberR=Prompt("Введите позицию элемента в строке => ");
int numberC=Prompt("Введите позицию элемента в колонке => ");
SearcheElementArray(array);
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

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void SearcheElementArray(int[,] array)
{   
    if (numberR<=0||numberC<=0)
    {
       Console.WriteLine($"Некорректный ввод");
    }
    else
    {
        if (numberR <= array.GetLength(0)&&numberC <= array.GetLength(1))
        {
            Console.WriteLine($"Искомый элемент {array[numberR - 1, numberC - 1]}");
        }    
        else 
        {
            Console.WriteLine("Такого элемента нет ");
        }  
    }      
}

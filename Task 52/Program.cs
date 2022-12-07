void FillRandomValuesInArray(ref int[,] NumsArray)
{
    for (int i = 0; i < NumsArray.GetLength(0); i++)
        for (int j = 0; j < NumsArray.GetLength(1); j++)
            NumsArray[i,j] = new Random().Next(0, 100);
       
    
}

void PrintArray(int[,] NumsArray)
{
    for (int i = 0; i < NumsArray.GetLength(0); i++)
    {    
        for (int j = 0; j < NumsArray.GetLength(1); j++)
            Console.Write($"{NumsArray[i,j]} \t");                
        
        Console.WriteLine("");
    }    
}

string GetAverageOfColumns(int[,] NumsArray)
{
    
    int LinesCount = NumsArray.GetLength(0);
    int ColumnsCount = NumsArray.GetLength(1);
    double[] results = new double[ColumnsCount];
    
    for (int j = 0; j < ColumnsCount; j++)
    {    
        results[j] = 0;
        
        for (int i = 0; i < LinesCount; i++)
            results[j] += NumsArray[i,j];
        
        results[j] = Math.Round(results[j] / LinesCount, 1, MidpointRounding.AwayFromZero);
    }

    return string.Join("; ", results);

}

int m = 3;
int n = 4;

int[,] NumsArray = new int[m, n];
FillRandomValuesInArray(ref NumsArray);
PrintArray(NumsArray);

Console.WriteLine($"Average of columns: {GetAverageOfColumns(NumsArray)}");

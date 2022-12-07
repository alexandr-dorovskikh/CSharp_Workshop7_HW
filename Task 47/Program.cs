void FillRandomValuesInArray(ref double[,] NumsArray)
{
    for (int i = 0; i < NumsArray.GetLength(0); i++)
        for (int j = 0; j < NumsArray.GetLength(1); j++)
            NumsArray[i,j] = Math.Round(new Random().NextDouble(), 1, MidpointRounding.AwayFromZero) + new Random().Next(-9, 10);
       
    
}

void PrintArray(double[,] NumsArray)
{
    for (int i = 0; i < NumsArray.GetLength(0); i++)
    {    
        Console.Write($"{i}:[");
        
        for (int j = 0; j < NumsArray.GetLength(1); j++)
            {
                Console.Write($"{NumsArray[i,j]}");
                if (j + 1 != NumsArray.GetLength(1)) Console.Write("\t"); 
            }    
        
        Console.WriteLine("]");
    }    
}

int m = 3;
int n = 4;

double[,] NumsArray = new double[m, n];
FillRandomValuesInArray(ref NumsArray);
PrintArray(NumsArray);
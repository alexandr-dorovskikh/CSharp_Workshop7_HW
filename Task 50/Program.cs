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

int m = 3;
int n = 4;

int[,] NumsArray = new int[m, n];
FillRandomValuesInArray(ref NumsArray);
PrintArray(NumsArray);

Console.Write("Enter line index: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter column index: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i >= 0 && i < m && j >= 0 && j < n)
    Console.WriteLine($"Value: {NumsArray[i,j]}");
else 
    Console.WriteLine("Indexes are out of range");

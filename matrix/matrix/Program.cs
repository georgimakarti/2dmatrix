int[,] Matrix = new int[9,9];

FillMatrix(Matrix);
SumDiagonal(Matrix);
PrintMatrix(Matrix);
Console.WriteLine();
MaxNumChecker(Matrix);

void SumDiagonal(int[,] matrix)
{
    Console.WriteLine("Въведете К");
    int K = Convert.ToInt32(Console.ReadLine());

    int SumOfDiag = 0;
    for (int i = 0; i < K; i++)
    {
        SumOfDiag += matrix[i, i];
    }
    Console.WriteLine(SumOfDiag);
}

void FillMatrix(int[,] matrix)
{
    int minRnd = 1;
    int maxRnd = 9;
    var rnd = new Random();
    for (int i = 0; i < 9; i++)
    {
        minRnd += 10;
        maxRnd += 10;
        for (int j = 0; j < 9; j++)
        {
            matrix[i, j] = rnd.Next(minRnd, maxRnd);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i , j] + " ");

        }
        Console.WriteLine();
    }
}

void MaxNumChecker(int[,] matrix)
{
    int MaxNum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for( int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i , j] > MaxNum)
            {
                MaxNum = matrix[i , j];
            }
        }
    }
    Console.WriteLine(MaxNum);
}
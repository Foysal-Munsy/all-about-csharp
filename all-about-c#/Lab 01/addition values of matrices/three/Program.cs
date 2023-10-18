int[,] arr1 = new int[3,3];
int[,] arr2 = new int[3, 3];
Console.WriteLine("Enter elements for first matrix:\n");
for(int i=0; i<3; i++)
{
    for(int j=0; j<3; j++)
    {
        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Enter elements for second matrix:\n");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        arr2[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
int[,] sum = new int[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        sum[i, j] = arr1[i, j] + arr2[i, j];
    }
}
Console.WriteLine("The sum of two matrices are:\n");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine(sum[i, j] + " ");
    }
    Console.WriteLine();
}
Console.ReadLine();
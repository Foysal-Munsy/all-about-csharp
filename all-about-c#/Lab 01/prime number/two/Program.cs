//custom function

int[] ConcatArrays(int[] array1, int[] array2)
{
    int[] result = new int[array1.Length + array2.Length];
    int i = 0;

    foreach (int num in array1)
    {
        result[i] = num;
        i++;
    }

    foreach (int num in array2)
    {
        result[i] = num;
        i++;
    }

    return result;
}
bool IsPrime(int num)
{
    if (num <= 1) return false;
    if (num == 2) return true;

    for (int i = 2; i < num; i++)
        if (num % i == 0)
            return false;

    return true;
}
//main function code
Console.WriteLine("Enter the size of array:\n");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr1 = new int[n];
int[] arr2 = new int[n];
List<int> prime = new List<int>();
Console.WriteLine("value for array1:\n");
for (int i = 0; i < n; i++) arr1[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("value for array2:\n");
for (int i = 0; i < n; i++) arr2[i] = Convert.ToInt32(Console.ReadLine());
foreach(int val in ConcatArrays(arr1, arr2))
{
    if (IsPrime(val))
    {
        prime.Add(val);
    }
}

Console.WriteLine("Prime numbers are: " + string.Join(",",prime));

Console.ReadLine();

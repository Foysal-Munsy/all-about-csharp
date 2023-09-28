Console.WriteLine("Size of array:\n");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];
Console.WriteLine("Write the array element:\n");

for (int i = 0; i < size; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int mx = arr[0], mn = arr[0];
Console.WriteLine("The elements of the array are:\n");
for (int i = 0; i < size; i++)
{
    if (arr[i] > mx) mx = arr[i];
    if (arr[i] < mn) mn = arr[i];
}
Console.WriteLine("Minumum: {0}", mn);
Console.WriteLine("Maximum: {0}", mx);
Console.ReadLine();
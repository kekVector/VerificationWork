int a = 1, b = 20;
int n = 15;

int[] CreatArray(int N)
{
    return new int[N];
}

void PrintArray(int[] arr)
{
    Console.WriteLine(String.Join(' ', arr));
}

int[] FillArray(int[] arr, int A, int B)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(A, B+1);        
    }
    return arr;
}
int[] array = FillArray(CreatArray(n), a, b);
PrintArray(array);


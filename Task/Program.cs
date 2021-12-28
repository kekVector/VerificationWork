int a = 1, b = 20;
int n = 15;

int[] CreateArray(int N)
{
    return new int[N];
}

void PrintArray(int[] arr)
{
    Console.WriteLine(String.Join(' ', arr));
    Console.WriteLine();
}

int[] FillArray(int[] arr, int A, int B)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(A, B+1);        
    }
    return arr;
}

int[] RemoveOdd(int[] arr)
{
    int[] resultArr = CreateArray(0);
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0)
        {
            Array.Resize(ref resultArr, resultArr.Length + 1);
            resultArr[resultArr.Length - 1] = arr[i];
        }
        
    }
    return resultArr;
}

int[] array = FillArray(CreateArray(n), a, b);
PrintArray(array);
int[] answer = RemoveOdd(array);
PrintArray(answer);





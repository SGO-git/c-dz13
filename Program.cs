// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

System.Console.Write("Imput array length ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[N];
Random rand = new Random();


void FillArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 100);
    }

}

void PrintArr(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


FillArr(arr);
PrintArr(arr);

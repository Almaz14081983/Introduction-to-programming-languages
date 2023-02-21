// В качестве ДЗ
// Подумайте как одоптировать код упорядочевания массива от минимального к максимальному 
// Так чтобы упорядочиь в обратном порядке… сначало самый большой, в конце самый маленький
// Подводя итог можем сказать…


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[minPosition]) 
            {
                minPosition = j;
            }
        }

        int temporray = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporray;
    }
    Console.WriteLine(); 
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
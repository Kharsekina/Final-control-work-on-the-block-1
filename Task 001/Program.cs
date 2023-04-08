// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] Array1(int size)
{
   string []array1=new string[size];
   for (int i = 0; i < size; i++)
   {
    Console.WriteLine("Введите слово");
    array1[i]=Console.ReadLine();
   }
   return array1;
}

void PrintArray(string[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

string[] Array2(string[]array1)
{
   string [] array2=new string[array1.Length];
   int count=0;
   for (int i = 0; i < array1.Length; i++)
   {
    if(array1[i].Length<=3) 
    {
        array2[count]=array1[i];
        count++;
    }
   }
   return array2;
}


string []firstArray=Array1(5);
PrintArray(firstArray);

string [] secondArray=Array2(firstArray);
PrintArray(secondArray);
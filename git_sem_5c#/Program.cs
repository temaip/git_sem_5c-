
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Ввод размера массива");
// int size_array = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввод начального значения массива");
// int min_array = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввод конечного значения массива");
// int max_array = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size_array, min_array, max_array);

// ShowArray(myArray);
// int N = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//       if (  myArray[i] % 2 == 0 )
//     {
//         N++;
//     }
// }

// Console.WriteLine(N);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Ввод размера массива");
// int size_array = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввод начального значения массива");
// int min_array = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввод конечного значения массива");
// int max_array = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size_array, min_array, max_array);

// ShowArray(myArray);
// int N = 0;
// for (int i = 1; i < myArray.Length; i = i + 2)
// {
//      N = myArray[i] + N;
// }

// Console.WriteLine(N);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Ввод размера массива");
// int size_array = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввод начального значения массива");
// int min_array = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввод конечного значения массива");
// int max_array = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size_array, min_array, max_array);

// ShowArray(myArray);
// int max = myArray[0];
// int min = myArray[0];
// for (int i = 1; i < myArray.Length; i++)
// {
    
//     if (myArray[i] < min)
//     {
//         min = myArray[i];
//     }
// else
// {
//     if (myArray[i] > max)
//     {
//         max = myArray[i];
//     }
// }

// }

// Console.WriteLine("Максимальное число " + max);
// Console.WriteLine("Минимальное число " + min);
// Console.WriteLine("Разница между максимальным и минимальным " + (max - min));

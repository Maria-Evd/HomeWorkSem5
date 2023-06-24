// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



// Console.Write("Введите размер массива: ");
// int size = int.Parse(Console.ReadLine()!);
// int[] array = GetArray(size);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// // Функция заполнения массива

// int[] GetArray(int size) {   
//        int[] result = new int[size];  
//        for (int i = 0; i < size; i++)
//        {
//           result[i] = new Random().Next(100, 1000);   
//        }
//        return result;
//   }
// int count = 0;
// foreach (int el in array)
// {
//     count += el % 2 == 0 ? 1 : 0;
// }
// Console.WriteLine($"Количество четных элементов в массиве равно {count} ");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Console.Write("Введите размер массива: ");
// int size = int.Parse(Console.ReadLine()!);
// int[] array = GetArray(size);
// Console.WriteLine($"[{String.Join(", ", array)}]");

//  // Функция заполнения массива

//  int[] GetArray(int size) {   
//         int[] result = new int[size];  
//         for (int i = 0; i < size; i++)
//         {
//            result[i] = new Random().Next(1, 100);   
//         }
//         return result;
//  }
// int sum = 0;
// for (int i = 1; i < size; i += 2)
// {
//     sum += array[i];
// }
// Console.WriteLine($"Сумма элементов стоящих на нечетных индексах равна {sum}");



// Задача 38: Задайте массив целых двухзначных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [22, 42, 15, 77, 65] => 77 - 15 = 62**

// Console.Write("Введите размер массива: ");
// int size = int.Parse(Console.ReadLine()!);
// int[] array = GetArray(size);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// // Функция заполнения массива

// int[] GetArray(int size) {   
//     int[] result = new int[size];  
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(10, 100);   
//     }
//     return result;
// }
// int Max = array[0];
// int Min = array[1];
// foreach (int el in array)
// {
//     Max = el > Max ? el : Max;
//     Min = el < Min ? el : Min;
// }
// int difference = Max - Min;
// Console.WriteLine($"Разница между макс и мин элементом массива равна {Max} - {Min} = {difference}");


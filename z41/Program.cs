// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите М чисел");

int[] a = Convert.ToInt32(Console.ReadLine(""));
int count = 0;
 
for (int i = 0; i < a.Length; i++){if (a[i] > 0){count++;}}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");
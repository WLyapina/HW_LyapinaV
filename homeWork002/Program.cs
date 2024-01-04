//Домашнее задание семинара 2
// Задание 1: Напишите программу,
//которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23

//Console.Clear();
//Console.Write("Введите число: ");
//int Number = int.Parse(Console.ReadLine()!);
//if (Number % 7 == 0 && Number % 23 == 0)
//     Console.WriteLine("да");
// else
//     Console.WriteLine("нет");

// Задача 2: Напишите программу,
//которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной
//четверти плоскости, в которой находится эта точка.

//Console.Clear();
//Console.Write("Введите число x: ");
//int FirstNumber = int.Parse(Console.ReadLine()!);
//while (FirstNumber == 0){
//    Console.WriteLine("Вы ошиблись!\nЗначение x не может быть равно 0!\nВведите число x");
//    FirstNumber = int.Parse(Console.ReadLine()!);
//}
//Console.Write("Введите число y: ");
//int SecondNumber = int.Parse(Console.ReadLine()!);
//while (SecondNumber == 0){
//    Console.WriteLine("Вы ошиблись!\nЗначение y не может быть равно 0!\nВведите число y");
//    SecondNumber = int.Parse(Console.ReadLine()!);
//}
//if (FirstNumber > 0 && SecondNumber > 0){
//    Console.WriteLine("Это первая четверть плоскости");
//}
//if (FirstNumber < 0 && SecondNumber > 0){
//    Console.WriteLine("Это вторая четверть плоскости");
//}
//if (FirstNumber < 0 && SecondNumber < 0){
//    Console.WriteLine("Это третья четверть плоскости");
//}
//if (FirstNumber > 0 && SecondNumber < 0){
//    Console.WriteLine("Это четвертая четверть плоскости");
//}

//Задача 3:
// Напишите программу, которая принимает на вход целое
//число из отрезка [10, 99] и показывает наибольшую цифру числа.

//Console.Clear();
//Console.Write("Введите число от 10 до 99: ");
//int n = int.Parse(Console.ReadLine()!);
//while (n < 10 || n > 99){
//     Console.Write("Вы ошиблись!\nВведите число от 10 до 99: ");
//     n = int.Parse(Console.ReadLine()
//}
//int n2 = (n / 10) % 10;
//int n3 = n % 10;
//if (n2 >= n3){
//  Console.WriteLine($"{n2}");
//}
//else
//{
//  Console.WriteLine($"{n3}");
//}
//
//Задача 4: Напишите программу,
//которая на вход принимает натуральное число N,
//а на выходе показывает его цифры через запятую.
//
//
//Console.Clear();
// Console.Write("Введите натуральное число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n <= 0){
//      Console.Write("Вы ошиблись!\nВведите натуральное число: ");
//      n = int.Parse(Console.ReadLine()!);
// }
// while (n > 0){
//      int x = n % 10;
//      Console.Write($"{x}, ");
//      n = n / 10;
//  }
//  System.Console.WriteLine();

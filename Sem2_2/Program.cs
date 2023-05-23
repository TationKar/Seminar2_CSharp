/*12 Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число не кратно числу первому,
то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно
*/
Console.Clear();
Console.Write("Введите число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int scndNum = Convert.ToInt32(Console.ReadLine());
int result = firstNum % scndNum;
if (result == 0) 
Console.WriteLine($"{firstNum}, {scndNum} -> кратно");
else    
Console.WriteLine($"{firstNum}, {scndNum} -> не кратно, остаток {result}");

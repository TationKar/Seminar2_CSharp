/ **Задача 14:**

// Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.
//if((a > b || a < c) && (x > b || x < c) || d == 5))
//     0    +    0          1    +   0
 //         0          *          1
 //                    0                   +   1
 //                                1    
// 14  ->  нет
// 46  ->  нет
// 161 ->  да
Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num % 7;
int num3 = num % 23;
if((num2 == 0) && (num3 == 0))
    Console.WriteLine("кратно");
else
    Console.WriteLine("не кратно");
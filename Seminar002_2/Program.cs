Console.Clear();
int num = new Random().Next (100, 1000);
Console.WriteLine(num); // 223
int a1 = num / 100;
int a2 = num % 10;
int a11 = a1 * 10;
int result = a11 + a2;
Console.WriteLine($"Модифицированное число от {num} -> {result}");
/* 11 Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа*/




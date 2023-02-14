Console.Clear();
Console.Write("Write first number: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Write second number: ");
int num2 = int.Parse(Console.ReadLine()!);
if(num1 * num1 == num2 || num1 / num2 == num2 )
{
    Console.WriteLine($"{num1}, {num2} - da");
}
else
{
    Console.WriteLine($"{num1}, {num2} - net ");
}
 /*Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.*/









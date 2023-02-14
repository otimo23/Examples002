Console.Clear();
Console.Write("Write first number: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Write second number: ");
int num2 = int.Parse(Console.ReadLine()!);
if(num1%num2 ==0)
{
    Console.WriteLine($"{num1}, {num2} - kratno");
}
else
{
    int reminder = num1 % num2; 
    Console.WriteLine($"{num1}, {num2} - ne kratno, ostatok = {reminder} ");
}
/*12 Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число не кратно числу первому,
то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно*/

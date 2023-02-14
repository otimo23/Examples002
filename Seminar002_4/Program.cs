Console.Clear();
Console.Write("Write first number: ");
int num = int.Parse(Console.ReadLine()!);
int numA = 7;
int numB = 23;

if(num % numA ==0 && num % numB ==0)
{
    Console.WriteLine($"{num} - kratno 7 and 23");
}
else
{
 
    Console.WriteLine($"{num} - ne kratno 7 and 23");
}
/*Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.*/

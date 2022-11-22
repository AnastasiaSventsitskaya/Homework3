// Программа, которая принимает на вход число и проверяет, является ли оно палиндромом.

Console.WriteLine("Write number: ");
String num = Console.ReadLine();
bool isPalindrom = true;

for (int i = 0; i < num.Length / 2; i++)
{
    if (num[i] != num[num.Length - 1 - i])
    { 
        isPalindrom = false;
        break;
    }
}
if (isPalindrom)
{
    Console.WriteLine("Число является палиндромом");
}
else 
{
    Console.WriteLine("Число не является палиндромом");
}

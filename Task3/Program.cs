// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N



Console.WriteLine("Write number");
int N = Convert.ToInt32(Console.ReadLine());

for (var counter = 1; counter <= N; counter++) 
{
  Console.Write(Math.Pow(counter, 3) + " ");
}

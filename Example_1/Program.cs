
//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначиное число ");

int namber = int.Parse(Console.ReadLine());

int secondnNumber = namber % 100 / 10;

Console.WriteLine(secondnNumber);

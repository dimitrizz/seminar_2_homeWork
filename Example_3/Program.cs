
//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.


int namber = int.Parse(Console.ReadLine());

if (namber >= 1 && namber <= 7) {
    
    if (namber > 5) {
       Console.WriteLine("Выходной!"); 
    } else {
        Console.WriteLine("Рабочий день..."); 
    } 
    
} else {

    Console.WriteLine("Введены некоректные данные");
}


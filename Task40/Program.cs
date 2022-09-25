//  Задание 40: Напишите программу, 
//которая принимает вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины
Console.Clear();
int A, B, C;
Console.Write("Введите длины сторон треугольника: ");
while (!int.TryParse(Console.ReadLine(), out A) || A < 0){
Console.Write("Ошибка! Введите положительное число: ");
}
Console.Write("Введите длины сторон треугольника: ");
while (!int.TryParse(Console.ReadLine(), out B) || B < 0){
Console.Write("Ошибка! Введите положительное число: ");
}
Console.Write("Введите длины сторон треугольника: ");
while (!int.TryParse(Console.ReadLine(), out C) || C < 0){
Console.Write("Ошибка! Введите положительное число: ");
}
 if (A < B + C & B < A +C & C < A +B){
    Console.WriteLine("Может: ");
 } else {
    Console.Write(" Не может: ");
 }
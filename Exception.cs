using System;


public class Exceptio
{
    // public static void Main()
    // {


    //     try
    //     {
    //         int X = 5;
    //         int Y = X / 0;
    //         Console.WriteLine($"Результат: {Y}");
    //     }
    //     catch
    //     {
    //         Console.WriteLine("Возникло исключение!");
    //     }



    //     int x = 1;
    //     int y = 0;
        
    //     try
    //     {
    //         int result1 = x / y;
    //         int result2 = y / x;
    //     }
    //     catch (DivideByZeroException) when (y == 0)
    //     {
    //         Console.WriteLine("y не должен быть равен 0");
    //     }
    //     catch (DivideByZeroException ex)
    //     {
    //         Console.WriteLine(ex.Message);
    //     }



    //     // тип Exception
    //     try
    //     {
    //         int w = 5;
    //         int q = w / 0;
    //         Console.WriteLine($"Результат: {q}");
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine($"Исключение: {ex.Message}");
    //         Console.WriteLine($"Метод: {ex.TargetSite}");
    //         Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
    //     }



    //     // Генерація виключення та оператор throw
    //     try
    //     {
    //         Console.Write("Введите имя: ");
    //         string? name = Console.ReadLine();
    //         if (name == null || name.Length < 2)
    //         {
    //             throw new Exception("Длина имени меньше 2 символов");
    //         }
    //         else
    //         {
    //             Console.WriteLine($"Ваше имя: {name}");
    //         }
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine($"Ошибка: {e.Message}");
    //     }







    //     // Використання checked:
    //     int a = int.MaxValue;
    //     int b = 1;

    //     try
    //     {
    //         checked
    //         {
    //             int result = a + b; // Виникне OverflowException, оскільки результат перевищує максимальне значення int
    //         }
    //     }
    //     catch (OverflowException ex)
    //     {
    //         Console.WriteLine("Переповнення: " + ex.Message);
    //     }


    //     // икористання unchecked:

    //     int A = int.MaxValue;
    //     int B = 1;

    //     unchecked
    //     {
    //         int result = A + B; // Результат буде -2147483648, немає винятку, але значення обрізано до допустимого діапазону int
    //     }


    // }
}
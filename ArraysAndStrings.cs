using System;

// Arrays and strings
public class ArraysAndString
{
    // public static void Main(string[] args)
    // {
    //     // OneDdimensionalArrays();
    //     // MultidimensionalArrays();
    //     // WorkWithStrings();
    // }


    // one-dimensional arrays
    public static void OneDdimensionalArrays() 
    {
        // тип_переменной[] название_массива;
        int[] numbers;

        // Після визначення змінної масиву ми можемо надати їй певне значення:
        int[] nums = new int[4];


        int[] nums2 = new int[4] { 1, 2, 3, 5 };
 
        int[] nums3 = new int[] { 1, 2, 3, 5 };
        
        int[] nums4 = new[] { 1, 2, 3, 5 };
    
        int[] nums5 = { 1, 2, 3, 5 };

        string[] people = { "Tom", "Sam", "Bob" };


        // Індекси та одержання елементів масиву
        int[] numbers_ = { 1, 2, 3, 5 };
 
       
        Console.WriteLine(numbers_[3]);  // 5
        
       
        var n = numbers_[1];     // 2
        Console.WriteLine(n);  // 2


        // Властивість Length та довжина масиву
        int[] _numbers = { 1, 2, 3, 5 };
 
        Console.WriteLine(_numbers.Length);  // 4




        // Перебір масивів
        int[] numberS = { 1, 2, 3, 4, 5 };
        foreach (int i in numberS)
        {
            Console.WriteLine(i);
        }

        // for
        for (int i = 0; i < numberS.Length; i++)
        {
            Console.WriteLine(numberS[i]);
        }


        // У той же час цикл для більш гнучкий у порівнянні з foreach. 
        // Якщо foreach послідовно витягує елементи контейнера і тільки для читання
        for (int i = 0; i < numberS.Length; i++)
        {
            numberS[i] = numberS[i] * 2;
            Console.WriteLine(numberS[i]);
        }
    }




    // Multidimensional arrays
    public static void MultidimensionalArrays()
    {
        int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };
 
        int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };

        // Усі можливі способи визначення двовимірних масивів:
        int[,] num;
        int[,] nums = new int[2, 3];
        int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
        int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
        int[,] nums5 = new [,]{ { 0, 1, 2 }, { 3, 4, 5 } };
        int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };


        // Масиви можуть мати і більшу кількість вимірів. Оголошення тривимірного масиву могло б виглядати так:
        int[,,] nums33 = new int[2, 3, 4];



        int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }};
        foreach (int i in numbers)
            Console.Write($"{i} ");


        // numbers.GetUpperBound(0) + 1
        // можна отримати кількість рядків таблиці

        // numbers.Length / количество_строк
        // можна отримати кількість елементів у кожному рядку:

        
 
        int rows = numbers.GetUpperBound(0) + 1;    // кількість рядків
        int columns = numbers.Length / rows;        // кількість стопчиків
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{numbers[i, j]} \t");
            }
            Console.WriteLine();
        }
    }




    // ## Work with strings
    public static void WorkWithStrings() 
    {
        string aFriend = "Bill";
        Console.WriteLine(aFriend);
        Console.WriteLine("Hello " + aFriend);
        // or
        Console.WriteLine($"Hello {aFriend}");


        string firstFriend = "Maria";
        string secondFriend = "Sage";
        Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

        //  You can find the length of a string using `Length`

        Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
        Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

        // Do more with strings

        // You want to **trim** the spaces from the strings. 
        // The `Trim` method and related methods `TrimStart` and `TrimEnd` do that work. You can just use those methods to remove leading and trailing spaces.
        string greeting = "      Hello World!       ";
        Console.WriteLine($"[{greeting}]");

        string trimmedGreeting = greeting.TrimStart();
        Console.WriteLine($"[{trimmedGreeting}]");

        trimmedGreeting = greeting.TrimEnd();
        Console.WriteLine($"[{trimmedGreeting}]");

        trimmedGreeting = greeting.Trim();
        Console.WriteLine($"[{trimmedGreeting}]");


        // Replace
        string sayHello = "Hello World!";
        Console.WriteLine(sayHello);
        sayHello = sayHello.Replace("Hello", "Greetings");
        Console.WriteLine(sayHello);



        //Two other useful methods make a string ALL CAPS or all lower case:
        Console.WriteLine(sayHello.ToUpper());
        Console.WriteLine(sayHello.ToLower());


        // Search strings
        string songLyrics = "You say goodbye, and I say hello";
        Console.WriteLine(songLyrics.Contains("goodbye"));
        Console.WriteLine(songLyrics.Contains("greetings"));
    }
}
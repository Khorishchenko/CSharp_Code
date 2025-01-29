using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class IntroductiontoGenerics
{
    public static void Main()
    {
        // Generics

        Pair<int> intPair = new Pair<int>(5, 10);
        Console.WriteLine($"First: {intPair.First}, Second: {intPair.Second}"); // Виведе: First: 5, Second: 10

        Pair<string> stringPair = new Pair<string>("Hello", "World");
        Console.WriteLine($"First: {stringPair.First}, Second: {stringPair.Second}"); // Виведе: First: Hello, Second: World




        Calculator<int> intCalculator = new Calculator<int>();
        int sum = intCalculator.Add(5, 3); // Результат: 8

        Calculator<double> doubleCalculator = new Calculator<double>();
        double result = doubleCalculator.Add(2.5, 1.8); // Результат: 4.3




        int[] intArray = { 3, 7, 1, 9, 5 };
        int maxInt = FindMax(intArray); // Результат: 9

        string[] stringArray = { "apple", "banana", "orange", "pear" };
        string maxString = FindMax(stringArray); // Результат: "pear"




        // Iterator
        MyList<int> number = new MyList<int>();
        number.Add(1);
        number.Add(2);
        number.Add(3);

        foreach (int num in number)
        {
            Console.WriteLine(num);
        }





        // Collection
        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages.Add("Alice", 25);
        ages.Add("Bob", 30);

        Console.WriteLine($"Alice's age: {ages["Alice"]}");
        Console.WriteLine($"Bob's age: {ages["Bob"]}");
    }



    // Створення Generic-класів:
    // Ось приклад створення простого Generic-класу Pair<T> для збереження пари значень будь-якого типу:
    public class Pair<T>
    {
        public T First { get; set; }
        public T Second { get; set; }

        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }
    }



    // Використання обмежень:
    // Обмеження допомагають вказати, які типи можуть бути використані як параметри у Generics:
    public class Calculator<T> where T : struct // Обмеження where T : struct вказує, що тип T повинен бути структурою.
    {
        public T Add(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
            // використання ключового слова dynamic дозволяє виконати 
            // відповідні операції додавання для різних типів даних T
        }
    }


    // // Створення Generic-методів:
    // Цей метод можна використовувати для будь-яких типів даних, 
    // що реалізують IComparable<T>, включаючи числа, рядки та інші, 
    // які можна порівнювати між собою. Обмеження where T : IComparable<T> гарантує, 
    // що тип T буде мати необхідний метод CompareTo для порівняння.
    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        if (array.Length == 0)
            throw new ArgumentException("Array is empty");

        T max = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }
        return max;
    }





    // Iterator
    // Ось приклад створення ітератора для перебору елементів списку:

    public class MyList<T> : IEnumerable<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
using System;

class StructuresEnumeration
{
    public static void Main()
    {
        // Коротший синтаксис ініціалізації структури Point
        Point p = new Point { X = 10, Y = 20 };


        // Використання структури для представлення дати та часу.
        DateTime dt = new DateTime { Year = 2023, Month = 6, Day = 24, Hour = 15, Minute = 30, Second = 0 };



        // Використання структури для представлення дати та часу.
        Color myColor = new Color { Red = 255, Green = 0, Blue = 0 }; // Червоний колір



        // Використання: 
        DaysOfWeek today = DaysOfWeek.Wednesday;



        // Ось приклади використання типу Nullable:
        int? nullableInt = null;
        double? nullableDouble = 3.14;

        if (nullableInt.HasValue)
        {
            Console.WriteLine("Nullable int has a value: " + nullableInt.Value);
        }
        else
        {
            Console.WriteLine("Nullable int is null");
        }

        if (nullableDouble.HasValue)
        {
            Console.WriteLine("Nullable double has a value: " + nullableDouble.Value);
        }
        else
        {
            Console.WriteLine("Nullable double is null");
        }
    }

    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }


    // Використання структури для представлення дати та часу.
    struct DateTime
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
    }

    // Використання структури для представлення кольорів за RGB-кодом.
    struct Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }


    // Перелічування (enum) в C#
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }



}
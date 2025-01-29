using System;

class Operator
{
    // public static void Main()
    // {
    
    // // Приклад використання перевантажених унарних операторів
    //     ComplexNumber number1 = new ComplexNumber(2, 3);
    //     ComplexNumber number2 = -number1;
    //     ComplexNumber number3 = ++number2;




    // // Приклад використання перевантаженого бінарного оператора +
    //     Vector vector1 = new Vector(2, 3);
    //     Vector vector2 = new Vector(1, 5);
    //     Vector vector3 = vector1 + vector2;




    // // Приклад використання перевантажених операторами порівняння.
    //     LogicalNumber LogicalNumber1 = new LogicalNumber("John", 25);
    //     LogicalNumber LogicalNumber2 = new LogicalNumber("Jane", 30);

    //     if (LogicalNumber1 == LogicalNumber2)
    //     {
    //         Console.WriteLine("LogicalNumbers have the same age.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("LogicalNumbers have different ages.");
    //     }

    //     if (LogicalNumber1 >= LogicalNumber2)
    //     {
    //         Console.WriteLine("John is older or the same age as Jane.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("John is younger than Jane.");
    //     }
    // }
}


 // Перевантаження унарних операторів:
    class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Перевантаження унарного оператора -
        public static ComplexNumber operator -(ComplexNumber c)
        {
            return new ComplexNumber(-c.Real, -c.Imaginary);
        }

        // Перевантаження унарного оператора ++
        public static ComplexNumber operator ++(ComplexNumber c)
        {
            return new ComplexNumber(c.Real + 1, c.Imaginary + 1);
        }
    }



// Перевантаження бінарних операторів:
class Vector
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Перевантаження бінарного оператора +
    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }
}




// Перевантаження операторами порівняння:
class LogicalNumber
{
    public string Name { get; set; }
    public int Age { get; set; }

    public LogicalNumber(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Перевантаження оператору ==
    public static bool operator ==(LogicalNumber p1, LogicalNumber p2)
    {
        return p1.Age == p2.Age;
    }

    // Перевантаження оператору !=
    public static bool operator !=(LogicalNumber p1, LogicalNumber p2)
    {
        return p1.Age != p2.Age;
    }

    // Перевантаження оператору >=
    public static bool operator >=(LogicalNumber p1, LogicalNumber p2)
    {
        return p1.Age >= p2.Age;
    }

    // Перевантаження оператору <=
    public static bool operator <=(LogicalNumber p1, LogicalNumber p2)
    {
        return p1.Age <= p2.Age;
    }
}
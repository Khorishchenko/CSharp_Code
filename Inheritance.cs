using System;

class Inheritance
{
    public static void Main()
    {
        Dog dog = new Dog();
        dog.Eat(); // Виведе: "Animal is eating."
        dog.Bark(); // Виведе: "Dog is barking."


           
        // Ключове слово base
        Person person = new Person("Bob");
        person.Print();     // Bob
        Employee employee = new Employee("Tom", "Microsoft");
        employee.Print();   // Tom



        // Порядок виклику конструкторів
        Employee tom = new Employee("Tom", 22, "Microsoft");





        //  Віртуальні методи:
        Animal animal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        animal.MakeSound(); // Виведе: "Animal makes a sound."
        dog.MakeSound();    // Виведе: "Dog barks."
        cat.MakeSound();    // Виведе: "Cat meows."




        // Аналіз базового класу Object.
        MyClass obj1 = new MyClass() { Value = 10 };
        MyClass obj2 = new MyClass() { Value = 10 };

        Console.WriteLine(obj1.Equals(obj2)); // Виведе: False, оскільки посилання на об'єкти різні
        Console.WriteLine(obj1.GetHashCode()); // Виведе хеш-код для obj1
        Console.WriteLine(obj2.GetHashCode()); // Виведе хеш-код для obj2
    }



    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }




    // Ключове слово base
    class Person
    {
        public string Name { get; set;}
        public Person(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
 
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
        }
    }



    // Порядок виклику конструкторів
    // class Person
    // {
    //     string name;
    //     int age;
    
    //     public Person(string name)
    //     {
    //         this.name = name;
    //         Console.WriteLine("Person(string name)");
    //     }
    //     public Person(string name, int age) : this(name)
    //     {
    //         this.age = age;
    //         Console.WriteLine("Person(string name, int age)");
    //     }
    // }
    // class Employee : Person
    // {
    //     string company;
    
    //     public Employee(string name, int age, string company) : base(name, age)
    //     {
    //         this.company = company;
    //         Console.WriteLine("Employee(string name, int age, string company)");
    //     }
    // }




    // Віртуальні методи:
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }




    // Оголошення абстрактного класу виглядає так:
    abstract class Shape
    {
        // Абстрактний метод без реалізації
        public abstract double CalculateArea();
    }


    class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public override double CalculateArea()
        {
            return width * height;
        }
    }




    // Аналіз базового класу Object.

    class MyClass
    {
        public int Value { get; set; }

        // Код класу
    }
}
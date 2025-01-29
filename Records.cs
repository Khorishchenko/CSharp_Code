using System;
using System.Linq;
using System.Collections.Generic;

class Records
{
    public static void Main()
    {
        // Визначення лямбда-виразу для обчислення квадрата числа
        Func<int, int> square = x => x * x;

        int result = square(5);
        Console.WriteLine("Square of 5: " + result);




        // 1. Сортування списку:
        // List<int> numbers = new List<int> { 5, 2, 9, 1, 5, 6 };

        // // Сортування списку за зростанням за допомогою лямбда-виразу
        // numbers.Sort((a, b) => a.CompareTo(b));

        // Console.WriteLine("Sorted numbers:");
        // foreach (int num in numbers)
        // {
        //     Console.Write(num + " ");
        // }



        // 2. Вибір елементів зі списку, що задовольняють певний умови:
        // List<int> numbers = new List<int> { 5, 2, 9, 1, 5, 6 };

        // // Вибір парних чисел за допомогою лямбда-виразу
        // var evenNumbers = numbers.Where(num => num % 2 == 0);

        // Console.WriteLine("Even numbers:");
        // foreach (int num in evenNumbers)
        // {
        //     Console.Write(num + " ");
        // }



        // 4. Передача лямбда-виразу як аргументу до методу:
        int[] numbers = { 5, 2, 9, 1, 5, 6 };

        // Передача лямбда-виразу для виведення значень масиву
        ProcessArray(numbers, num => Console.Write(num + " "));




        // Принципи роботи операторів порівняння, Equals, GetHashCode для записів:
        Person person1 = new Person("John", "Doe", 30);
        Person person2 = new Person("John", "Doe", 30);

        bool areEqual = person1 == person2; // true, порівнюється за значеннями властивостей
        bool areSame = ReferenceEquals(person1, person2); // false, записи є різними об'єктами

        Console.WriteLine("areEqual is " + areEqual);
        Console.WriteLine("areSame is " + areSame);


        // Практичні приклади використання:
        List<Person> people = new List<Person>
        {
            new Person("Alice", "Johnson", 25),
            new Person("Bob", "Smith", 30),
            new Person("Eve", "Brown", 28)
        };

        var youngPeople = people.Where(person => person.Age < 30);
        foreach (var person in youngPeople)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}, Age: {person.Age}");
        }


        // 1. Представлення контактних даних:
        Contact person = new Contact("John", "Doe", "john@example.com");
        Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Email: {person.Email}");


        // 2. Передача параметрів в функції:
        Point point = new Point(5, 10);
        ProcessPoint(point);


        // 3. Збереження інформації про книги:
        List<Book> library = new List<Book>
        {
            new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925),
            new Book("To Kill a Mockingbird", "Harper Lee", 1960),
            new Book("1984", "George Orwell", 1949)
        };

        foreach (var book in library)
        {
            Console.WriteLine($"{book.Title} by {book.Author}, Year: {book.Year}");
        }

        // 5. Передача записів між методами:
        Order newOrder = CreateOrder(1, "Smartphone", 599.99m);
        ProcessOrder(newOrder);
        
    }

    static void ProcessArray(int[] array, Action<int> action)
    {
        foreach (int num in array)
        {
            action(num);
        }
        Console.Write("\n");
    }


    // Синтаксис оголошення запису:
    public record Person(string FirstName, string LastName, int Age);

    public record Contact(string FirstName, string LastName, string Email);


    // 2. Передача параметрів в функції:
    public record Point(int X, int Y);

    static void ProcessPoint(Point point)
    {
        Console.WriteLine($"X: {point.X}, Y: {point.Y}");
    }



     // 3. Збереження інформації про книги:
    public record Book(string Title, string Author, int Year);

 


    // 5. Передача записів між методами:
    public record Order(int OrderId, string Product, decimal Price);

    Order CreateOrder(int orderId, string product, decimal price)
    {
        return new Order(orderId, product, price);
    }

    void ProcessOrder(Order order)
    {
        Console.WriteLine($"Order #{order.OrderId}: {order.Product}, Price: {order.Price:C}");
    }

  
}
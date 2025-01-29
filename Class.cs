using System;


// Top-Level Statement
// Console.WriteLine("Hello, World!");

public class Class{

    // public static void Main()
    // {
    //     Console.ForegroundColor = ConsoleColor.Blue;
    //     Person tom = new Person();
    //     tom.age = 10;

    //     string personName = tom.name;
    //     int personAge = tom.age;
    //     Console.WriteLine($"Имя: {personName}  Возраст {personAge}");   // Имя: Undefined  Возраст: 0
        
    //     // устанавливаем новые значения полей
    //     tom.name = "Tom";
    //     tom.age = 37;
        

    //     // обращаемся к методу Print
    //     tom.Print();


    //     // Узагальнений метод Print<T>()
    //     tom.Prints("string");



    //     // В мові програмування C#, короткий синтаксис однорядкових методів називається "лямбда-виразом
    //     // Ось загальна структура лямбда-виразу в C#:

    //     // (parameters) => expression

    //     // де:
    //     // parameters - параметри функції,
    //     // expression - один рядок виразу, який представляє тіло функції.

    //     int result = tom.add(5, 3);
    //     Console.WriteLine($"result is {result}");

    //     bool even = tom.isEven(6); 
    //     Console.WriteLine($"result is {even}");

    //     int length = tom.strLength("Hello");
    //     Console.WriteLine($"result is {length}");




    //     // реалізація тіла методу як виразу. C#
    //     string str = "";
    //     Console.WriteLine(tom.Add(5, 6));
    //     Console.WriteLine(tom.IsEmpty(str));
    //     Console.WriteLine(tom.GetDeviceName(str));





    //     // Створення конструкторів
    //     Persons toms = new Persons();           // Виклик першого конструктора без параметрів
    //     Persons bob = new Persons("Bob");       // виклик 2-го конструктора з одним параметром
    //     Persons sam = new Persons ("Sam", 25);  // Виклик 3-го конструктора з двома параметрами
        
    //     toms.Print();          
    //     bob.Print();          
    //     sam.Print();


    //     // Починаючи з версії C# 9 ми можемо скоротити виклик конструктора, прибравши з нього назву типу:
    //     Persons Tom = new (); // так само новий Person();
    //     Persons Bob = new ("Боб"); // аналогічно новий Person("Bob");
    //     Persons Sam = new ("Боб", 25); // аналогічно новий Person("Sam", 25);





    //     // Деконструктори
    //     // У цьому випадку ми могли б виконати декомпозицію об'єкта Person так:
    //     Per per = new Per("Tom", 33);
 
    //     (string name, int age) = per;
        
    //     Console.WriteLine(name);    // Tom
    //     Console.WriteLine(age);     // 33


    //     // or
    //     Per obj = new Per("Tom", 33);
 
    //     string name_; int age_;
    //     obj.Deconstruct(out name_, out age_);

    //     // мы можм использовать прочерк _. 
    //     (_, int _age) = obj;

    // }
}



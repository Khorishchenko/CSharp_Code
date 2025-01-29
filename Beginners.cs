// СТРУКТУРА ПРОГРАМИ

// first line code 
using System;

// Namespaces Here is the same code without the System namespace:

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         System.Console.WriteLine("Hi there!");
//     }
// }



// The next line of code in our program defines a class called Program using the class keyword.

// # public class Program
// {

// }




// In C#, each application has an entry point, or a starting point, which is a method called Main.

//  public static void Main(string[] args)





// C# Syntax Basics
// Work with strings

// You can also combine strings. In this case, we'll use `+` to combine two strings:

public class Programs
{
    // public static void Main(string[] args)
    // {
    //     // ConsoleOutput();
    //     // ConsoleInput();
    //     // VariableTypes();
    //     // Operators();
    //     // LoopsAndConditionals();
    // }


    
   
    public static void ConsoleOutput()
    {
        string hello = "Hello world";
        Console.WriteLine(hello);
        Console.WriteLine("Welcome to C#!");
        Console.WriteLine("While the world...");
        Console.WriteLine(24.5);


        // one line of the value of several variables at once
        string name = "Tom";
        int age = 34;
        double height = 1.7;
        Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");


        // There is another way to output multiple values to the console at once:
        // string name = "Tom";
        // int age = 34;
        // double height = 1.7;
        // Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);


        // Console.Write

        // In addition to Console.WriteLine(), you can also use the Console.Write() method, 
        // which works exactly the same except that it does not add a line break, 
        // meaning that subsequent console output will be on the same line.

        // string name = "Tom";
        // int age = 34;
        // double height = 1.7;
        // Console.Write($"Имя: {name}  Возраст: {age}  Рост: {height}м");
        // Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);

    }


    // Console input
    public static void ConsoleInput()
    {
        // Console.ReadLine(). It allows you to get the entered string.
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello {name}");



        // Convert.ToInt32() (преобразует к типу int)
        // Convert.ToDouble() (преобразует к типу double)
        // Convert.ToDecimal() (преобразует к типу decimal)

        Console.Write("Enter name: ");
        string? name_ = Console.ReadLine();
        
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter salary: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine($"Name_: {name_} Age: {age} Height: {height}m Salary: {salary}$");
    }


    // ## Built-In Variable Types
    public static void VariableTypes()
    {
        int i = 10;
        double j = 5.5d;
        char c = 'C';

        Console.WriteLine($"{i}, {j} ,{c}");


        // ### The var keyword
        // C# має вбудовану функцію визначення типу, і ви можете використовувати ключове слово var
        // You can ONLY use the var keyword when creating and assigning the variable in one statement.

        var w                             = 10;
        var someReallyLongVariableName    = 9;
        var foo                           = "Something";

        Console.WriteLine(someReallyLongVariableName);


        var myNumber = 4f;
        Console.WriteLine(myNumber.GetType());


        // Type Casting

        int valueA = 10;
        decimal valueB = valueA; // Implicit conversion

        Console.WriteLine(valueB);

        decimal valueC = 10;
        //int valueD = valueC;      // This errors out because int cannot be implicitly converted to by a decimal
        int valueD = (int)valueC;   // Explicitly convert valueC to int with the (int) modifier

        Console.WriteLine(valueD);

    }



    // ## Operators
    public static void Operators(){

        var apples = 100m;   // Decimal value
        var oranges = 30m;   // Decimal value   

        // Basic arithmetic operators and assignment are available:


        Console.WriteLine(apples + oranges);
        Console.WriteLine(apples - oranges);
        Console.WriteLine(apples * oranges);


        Console.WriteLine(apples += 10);

        Console.WriteLine(apples -= 10);

        Console.WriteLine(apples *= 10);

        Console.WriteLine(apples /= 3m);


        // C# makes the inequality operators available as well, and a test for equality using ==

        Console.WriteLine(apples > oranges);
        Console.WriteLine(apples >= oranges);
        Console.WriteLine(apples < oranges);
        Console.WriteLine(apples <= oranges);
        Console.WriteLine(apples == oranges);
        Console.WriteLine(apples != oranges);



    }



    // ## Loops and Conditionals
    // Common to every programming language are the concepts 
    // - for
    // - while
    // - do
    // - if
    // - switch or case
    public static void LoopsAndConditionals(){

        var seconds = DateTime.Now.Second;
        Console.WriteLine("Current seconds: " + seconds);

        // One line if statement
        if (seconds % 2 == 0) 
            Console.WriteLine("Seconds are even");

        if (seconds % 2 == 1)
            Console.WriteLine("Seconds are odd");


        Console.WriteLine("This will always execute, even though it LOOKS LIKE its in the if statement");





        // Let's look a more complex branching scenario:
        var SecondsTwo = DateTime.Now.Second;
        Console.WriteLine("Current SecondsTwo: " + SecondsTwo);

        if (SecondsTwo % 2 == 0) {
            Console.WriteLine("SecondsTwoSecondsTwo are even");
        } else if (SecondsTwo % 3 == 0) {
            Console.WriteLine("SecondsTwoSecondsTwo are a multiple of 3");
        } else if (SecondsTwo % 5 == 0) {
            Console.WriteLine("SecondsTwoSecondsTwo are a multiple of 5");
        } else {
            Console.WriteLine("SecondsTwoSecondsTwo are neither even nor a multiple of 3");
        }

        if (seconds % 2 == 0)          Console.WriteLine("Seconds are even");
        else if (seconds % 3 == 0)     Console.WriteLine("Seconds are a multiple of 3");
        else if (seconds % 5 == 0)     Console.WriteLine("Seconds are a multiple of 5");
        else                           Console.WriteLine("Seconds are neither even nor a multiple of 3");






        // You can chain together conditional tests using the logical OR | and the logical AND & operators.
        var seconds_ = DateTime.Now.Second;
        // seconds_ = 7;
        Console.WriteLine("Current seconds_: " + seconds_);

        // Test for BOTH multiple of 2 AND a multiple of 3
        if (seconds_ % 2 == 0 & seconds_ % 3 == 0) {
            Console.WriteLine("Seconds are even AND a multiple of 3");
        } else if (seconds_ % 2 == 0) {
            Console.WriteLine("Seconds are even");
        } else if (seconds_ % 3 == 0) {
            Console.WriteLine("Seconds are a multiple of 3");

        // Test for seconds_ to be a multiple of 5 OR a multiple of 7
        } else if (seconds_ % 5 == 0 | seconds_ % 7 == 0) {
            Console.WriteLine("Seconds are a multiple of 5 OR 7");
        } else {
            Console.WriteLine("Seconds are neither even nor a multiple of 3");
        }




        var _seconds = DateTime.Now.Second;
        Console.WriteLine("Current _seconds: " + _seconds);

        bool MultipleOfThree() {
            Console.WriteLine("MultipleOfThree was called");
            return _seconds % 3 == 0;
        }

        if (_seconds % 2 == 0 && MultipleOfThree()) {
            Console.WriteLine("Seconds are even and a multiple of three");
        }

        if (_seconds != null && _seconds % 2 == 1) {
            Console.WriteLine("Seconds are odd");
        }






        // ### Switch Statements
        var dayOfTheWeek = DateTime.Now.DayOfWeek;
        // dayOfTheWeek = DayOfWeek.Friday;

        switch (dayOfTheWeek) {
            case DayOfWeek.Monday:
                Console.WriteLine("Does somebody have a case of the Mondays?");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("It's TACO TUESDAY at the cafe!");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Middle of the work-week... almost done!");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Friday is ALMOST HERE!!");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("The weekend starts.... NOW!");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("Relaxing... no school, no work...");
                break;
            case DayOfWeek.Sunday:
                Console.WriteLine("School and work tomorrow?  Better have some fun NOW!");
                break;
            default:
                Console.WriteLine("I don't care what day of the week it is... we're on HOLIDAY!");
                break;
        }





        // Ми також можемо додати додаткові тести для інструкцій case, використовуючи речення when:
        var dayOfTheWeek_ = DateTime.Now.DayOfWeek;
        var hourOfDay = DateTime.Now.Hour;
            
        /*  Extra conditions to test with */
        dayOfTheWeek_ = DayOfWeek.Monday;
        hourOfDay = 17;
        /* */

        switch (dayOfTheWeek_) {
            case DayOfWeek.Monday:
            case DayOfWeek.Tuesday:
            case DayOfWeek.Wednesday:
            case DayOfWeek.Thursday:
            case DayOfWeek.Friday when hourOfDay < 16:
                Console.WriteLine("Work work work...");
                break;
            case DayOfWeek.Friday when hourOfDay >= 16:
                Console.WriteLine("The weekend starts.... NOW!");
                break;
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                Console.WriteLine("Relaxing... no school, no work...");
                break;
        }



        
        // ### For Loops
        // [For loops](https://docs.microsoft.com/dotnet/csharp/language-reference/keywords/for) 

        // `for (Initializer; Condition; Iterator) { CODE TO EXECUTE }`
        // for (var i=0; i<5; i++)


        // ### For-Each Loops
        var arrNames = new string[] { "Fritz", "Scott", "Maria", "Jayme", "Maira", "James"};

        foreach (var name in arrNames) {
            Console.WriteLine(name);
        }

        for (var nameCounter = 0; nameCounter < arrNames.Length; nameCounter++) {
            Console.WriteLine(arrNames[nameCounter]);
        }


        // ### While and Do Loops

        var counter = 6;

        while (counter < 5) {
            counter++;
            Console.WriteLine(counter);
        }


        counter = 0;

        do {
            counter++;
            Console.WriteLine(counter);
        } while (counter < 5);


    }
}
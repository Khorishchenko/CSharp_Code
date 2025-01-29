using System;

public class Methods{

    

    // public static void Main()
    // {
    //     // Скорочений запис методів
    //     // SayHello();

    //     // // Але ми можемо порушити такий порядок, використовуючи іменовані параметри:
    //     // PrintPerson("Tom", company:"Microsoft", age: 37);  // Name: Tom  Age: 37  Company: Microsoft
    //     // PrintPerson(age:41, name: "Bob");          // Name: Bob  Age: 41  Company: Undefined
    //     // PrintPerson(company:"Google", name:"Sam"); // Name: Sam  Age: 1   Company: Google

 
    //     // GetMessageTwo();

    //     // Передача параметрів за посиланням та модифікатор ref
    //     // int number = 5;
    //     // Console.WriteLine($"Число до метода Increment: {number}");
    //     // Increment(ref number);
    //     // Console.WriteLine($"Число после метода Increment: {number}");


    //     // // Вихідні параметри. Модифікатор out
    //     // int numbers;
    //     // Sum(10, 15, out numbers);
    //     // Console.WriteLine(numbers);   // 25



    //     // // Масив параметрів та ключове слово params
    //     // int[] nums = { 1, 2, 3, 4, 5};
    //     // SumS(nums);
    //     // SumS(1, 2, 3, 4);
    //     // SumS(1, 2, 3);
    //     // SumS();

    // }

    static void PrintPerson(string name, int age = 1, string company = "Undefined")
    {
        Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
    }


    static void SayHello()
    {
        Console.WriteLine("Hello");
    }

    void SayHelloTwo() => Console.WriteLine("Hello");


    // Скорочена версія методів із результатом
    string GetMessage()
    {
        return "hello";
    }

    // аналогічний наступному методу:
    static string GetMessageTwo() => "hello";



    // Передача параметрів за посиланням та модифікатор ref
    static void Increment(ref int n)
    {
        n++;
        Console.WriteLine($"Число в методе Increment: {n}");
    }
    

    // Вихідні параметри. Модифікатор out
    static void Sum(int x, int y, out int result)
    {
        result = x + y;
    }



    // Масив параметрів та ключове слово params
    static void SumS(params int[]  numbers)
    {
        int result = 0;
        foreach (var n in numbers)
        {
            result += n;
        }
        Console.WriteLine(result);
    }

    
   
    // Якщо нам треба передати якісь інші параметри, то вони повинні вказуватися до параметра з ключовим словом params:
    static void Sum(int initialValue, params int[]  numbers)
    {
        int result = initialValue;
        foreach (var n in numbers)
        {
            result += n;
        }
        Console.WriteLine(result);
    }
}
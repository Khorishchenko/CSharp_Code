

// В мові програмування C#, специфікатори доступу (access modifiers) 
public class MyClass
{
        // содержимое класса

        public int PublicField;         // Доступно всюди
        private string PrivateField;    // Доступно тільки всередині класу
        protected int ProtectedField;   // Доступно всередині класу та його похідних класів
        internal double InternalField;  // Доступно всередині збірника


        // У даному прикладі, ConstantValue ініціалізується лише один раз у конструкторі MyClass, і після цього не може змінюватись.
        public readonly int ConstantValue; // Читаєме тільки поле
        public MyClass()
        {
            ConstantValue = 10; // Ініціалізація в конструкторі
        }
}


// Поля та методи класу
class Person
{
    public string name = "Undefined";   // имя
    public int age;                     // возраст
 
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }

    // Узагальнений метод Print<T>()
    public void Prints<T>(T value)
    {
      Type tp = typeof(T);
      Console.Write("Type: {0},   ", tp.Name);
      Console.WriteLine("value = {0}", value);
    }



    // lambda expressions
    // Лямбда-вираз для функції, яка додає два числа:
    public Func<int, int, int> add = (x, y) => x + y;


    // Лямбда-вираз для функції, яка перевіряє, чи число парне:
    public Func<int, bool> isEven = num => num % 2 == 0;


    // Лямбда-вираз для функції, яка повертає довжину рядка:
    public Func<string, int> strLength = s => s.Length;


    // Лямбда-вираз для вибору чисел менших за певне значення зі списку:
    static List<int> numbers = new List<int> { 1, 5, 3, 9, 2, 7 };
    public List<int> lessThanFive = numbers.Where(n => n < 5).ToList();




    // реалізація тіла методу як виразу. C#
    // Метод Add з використанням тіла виразу
    public int Add(int a, int b) => a + b;

    // Метод для перевірки, чи рядок є порожнім, використовуючи тіло виразу
    public bool IsEmpty(string str) => string.IsNullOrEmpty(str) ? true : false;

    // Метод для отримання назви пристрою з його ідентифікатора
    public string GetDeviceName(string deviceId) => 
        deviceId == "001" ? "Smartphone" : deviceId == "002" ? "Tablet" : "Unknown";
}




// class Persons
// {
//     public string name;
//     public int age;

//     // Створення конструкторів
//     public Persons()     // 1 конструктор
//     {
//         Console.WriteLine("Создание объекта Person");
//         name = "Tom";
//         age = 37;
//     }
   
//     public Persons(string n) { name = n; age = 18; }         // 2 конструктор
//     public Persons(string n, int a) { name = n; age = a; }   // 3 конструктор

//     public void Print()
//     {
//         Console.WriteLine($"Имя: {name}  Возраст: {age}");
//     } 
// }



// Ключове слово this
class People{
    public string name;
    public int age;  
       
    // Ланцюжок виклику конструкторів
    public People() : this("Неизвестно")    // первый конструктор
    { }
    public People(string name) : this(name, 18) // второй конструктор
    { }
    public People(string name, int age)     // третий конструктор
    {
        
        this.name = name;
        this.age = age;
    }
}


// Деконструктори
// Деконструктори (не плутати з деструкторами) дозволяють виконати декомпозицію об'єкта окремі частини.


class Per
{
    string name;
    int age;
    public Per(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
 
    public void Deconstruct(out string personName, out int personAge)
    {
        personName = name;
        personAge = age;
    }
}
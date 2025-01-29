using System;


public class Properties
{
    
    public static void Main()
    {
    // Приклад використання властивості

        People people = new People();
        people.Name = "John"; // Встановлюємо значення властивості Name
        string name = people.Name; // Отримуємо значення властивості Name
        Console.WriteLine(name); // Виведе "John"



        Person person = new Person();
 
        Console.WriteLine(person.Age); // 1

        // Змінюємо значення властивості
        person.Age = 37;
        Console.WriteLine(person.Age); // 37

        // пробуємо передати неприпустиме значення
        person.Age = -23; // Вік має бути в діапазоні від 1 до 120
        Console.WriteLine(person.Age); // 37 - вік не змінився

        
    }


    // тип_данних ім'я_властивості
    // {
    //     get
    //     {
    //         // Код для повернення значення властивості
    //         return де_данні_зберігаються;
    //     }
    //     set
    //     {
    //         // Код для встановлення значення властивості
    //         де_данні_зберігаються = value;
    //     }
    // }


    class People
    {
        private string name;

        // Властивість Name
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }



    //  властивості дозволяють вкласти додаткову логіку
    class Person
    {
        int age = 1;
        public int Age
        {
            set
            {
                if (value < 1 || value > 120)
                    Console.WriteLine("Вік має бути в діапазоні від 1 до 120");
                else
                    age = value;
            }
            get { return age; }
        }
    }


    // ініціалізація автоматичних властивостей.
    class PersonTwo
    {
        // Автоматична властивість Name з ініціалізацією
        public string Name { get; set; } = "John Doe";

        // Автоматична властивість Age з ініціалізацією
        public int Age { get; set; } = 30;
    }
}
using System;

// // namespace имя_пространства_имен
// // {
// //     // содержимое пространства имен
// // }


// // using Base; // подключение пространства имен Base


// Persons tom = new Persons("Tom"); // Ошибка - Visual Studio не видит класс Persons
// tom.Print();

// Base.Persons toms = new("Tom");
// toms.Print();          // Имя: Tom


// // Підключення простору імен
// Persons tom = new("Tom");
// tom.Print();     // Имя: Tom


// namespace Base
// {
//     class Persons
//     {
//         string name;
//         public Persons(string name) => this.name = name;
//         public void Print() => Console.WriteLine($"Имя: {name}");
//     }
// }


// // Вкладені простори імен

// // Для звернення до цих класів поза простором Base необхідно використовувати весь ланцюжок просторів імен:
// // using Base.PersonTypes; // підключення простору імен Base.PersonTypes для класу Person


// // Bases.OrganisationTypes.Company microsoft = new("Microsoft");
// // Person tom = new("Tom", microsoft);
// // tom.Print();  


// namespace Bases
// {
//     namespace PersonTypes
//     {
//         class Person
//         {
//             string name;
//             OrganisationTypes.Company company;
//             public Person(string name, OrganisationTypes.Company company) 
//             { 
//                 this.name = name; 
//                 this.company = company; 
//             }
//             public void Print()
//             {
//                 Console.WriteLine($"Имя: {name} ");
//                 company.Print();
//             }
//         }
//     }
//     namespace OrganisationTypes
//     {
//         class Company
//         {
//             string title;
//             public Company(string title) => this.title = title;
//             public void Print() => Console.WriteLine($"Название компании: {title}");
//         }
//     }
// }
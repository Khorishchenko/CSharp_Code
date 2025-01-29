using System;

public class Interfaces
{
    static public void Main()
    {
        ICounter counter = new Counter();

        counter.Increment();
        counter.Increment();
        counter.Increment();

        Console.WriteLine("Current count: " + counter.GetValue()); // Виведе: "Current count: 3"

        counter.Decrement();

        Console.WriteLine("Current count: " + counter.GetValue()); // Виведе: "Current count: 2"




        // Застосування інтерфейсу у програмі:
        Person person = new Person();
        Car car = new Car();
        DoAction(person);
        DoAction(car);




        //  Явна реалізація інтерфейсів
        BaseAction baseAction1 = new BaseAction();
 
        // baseAction1.Move(); //! Помилка - у BaseAction немає методу Move
        // Необхідне приведення до типу IAction
        // Небезпечне приведення

        ((IAction)baseAction1).Move();

        // безпечне приведення
        if (baseAction1 is IAction action) action.Move();

        // або так
        IAction baseAction2 = new BaseAction();
        baseAction2.Move();




        // Використання:
        Person person = new Person();
 
        ((ISchool)person).Study();
        ((IUniversity)person).Study();




        HeroAction action1 = new HeroAction();
        action1.Move();            // Move in BaseAction
        ((IAction)action1).Move(); // Move in HeroAction
        
        IAction action2 = new HeroAction();
        action2.Move();             // Move in HeroAction



        // Модифікатори доступу
        IMovable tom = new Person("Tom");
        
        // подписываемся на событие
        tom.MoveEvent += () => Console.WriteLine($"{tom.Name} is moving");
        tom.Move();
    }

    // Синтаксис визначення інтерфейсу:
    interface IMyInterface
    {
        // Оголошення методів і властивостей
        void Method1();
        int Property1 { get; set; }
    }


    // За замовчуванням
    // interface IMovable
    // {
    //     // реализация метода по умолчанию
    //     void Move()
    //     {
    //         Console.WriteLine("Walking");
    //     }
    // }



    // Приклад реалізації інтерфейсу в класі:
    class MyClass : IMyInterface
    {
        public void Method1()
        {
            // Реалізація методу Method1
        }

        public int Property1 { get; set; }
    }




    // Інтерфейс для лічильника:
    public interface ICounter
    {
        void Increment();
        void Decrement();
        int GetValue();
    }


    public class Counter : ICounter
    {
        private int count;

        public void Increment()
        {
            count++;
        }

        public void Decrement()
        {
            count--;
        }

        public int GetValue()
        {
            return count;
        }
    }


    
   
    
   
    // Застосування інтерфейсу у програмі:
    interface IMovable
    {
        void Move();
    }
    class Person : IMovable
    {
        public void Move() => Console.WriteLine("Человек идет");
    }
    struct Car : IMovable
    {
        public void Move() => Console.WriteLine("Машина едет");
    }

    static void DoAction(IMovable movable) => movable.Move();




    // Явна реалізація інтерфейсів
    interface IAction
    {
        void Move();
    }
    class BaseAction : IAction
    {
        void IAction.Move() => Console.WriteLine("Move in Base Class");
    }


    // ///////////
    class Person : ISchool, IUniversity
    {
        public void Study() => Console.WriteLine("Учеба в школе или в университете");
    }
    interface ISchool
    {
        void Study();
    }
    interface IUniversity
    {
        void Study();
    }


    class Person : ISchool, IUniversity
    {
        void ISchool.Study() => Console.WriteLine("Учеба в школе");
        void IUniversity.Study() => Console.WriteLine("Учеба в университете");
    }



    // Інша ситуація, коли у базовому класі вже реалізовано інтерфейс, 
    // але необхідно у похідному класі по-своєму реалізувати інтерфейс:

    interface IAction
    {
        void Move();
    }
    class BaseAction : IAction
    {
        public void Move() =>Console.WriteLine("Move in BaseAction");
    }
    class HeroAction : BaseAction, IAction
    {
        void IAction.Move() => Console.WriteLine("Move in HeroAction");
    }



    // Модифікатори доступу

    interface IMovable
    {
        protected internal void Move();
        protected internal string Name { get;}
        delegate void MoveHandler();
        protected internal event MoveHandler MoveEvent;
    }
    class Person : IMovable
    {
        string name;
        // явная реализация события - дополнительно создается переменная
        IMovable.MoveHandler? moveEvent;
        event IMovable.MoveHandler IMovable.MoveEvent
        {
            add => moveEvent += value;
            remove => moveEvent -= value;
        }
        // явная реализация свойства - в виде автосвойства
        string IMovable.Name { get => name; }
        public Person(string name) => this.name = name;
        // явная реализация метода
        void IMovable.Move()
        {
            Console.WriteLine($"{name} is walking");
            moveEvent?.Invoke();
        }
    }
}
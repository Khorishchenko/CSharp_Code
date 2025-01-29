using System;

class DelegatesEvents
{
    // Визначення делегатів
    delegate void Message();
    delegate void MyDelegate(int x); // Приклад оголошення делегата

     // Мультиделегати:
    delegate void MessageDelegate(string message);

    public static void Main()
    {
        // Призначення методу делегату

        Message mes; // 2. Створюємо змінну делегата
        mes = Hello; // 3. Привласнюємо цю змінну адресу методу
        mes(); // 4. Викликаємо метод


        // =====================================================================

        
        MyDelegate del = MyMethod; // Призначення методу делегату
        
        // Виклик методу через делегат
        del(5); // Виклик методу через делегат

        // Множинні виклики
        del += SomeOtherMethod; // Додавання ще одного методу до делегата
        del(10); // Виклик обох методів


        // =====================================================================



        // Виклик функції з переданими параметрами та оператором

        PerformOperation(5, 3, (x, y) => x + y); // Виведе: "Result: 8"




        // Використання мультиделегатів для комбінування декількох методів.

        MessageDelegate messageDelegate = (message) => Console.WriteLine($"Message: {message}");
        messageDelegate += (message) => Console.WriteLine($"Uppercase: {message.ToUpper()}");

        messageDelegate("Hello, world!"); // Виведе:
        // Message: Hello, world!
        // Uppercase: HELLO, WORLD!



        // Асинхронна обробка

        MathOperations math = new MathOperations();
        MathOperations.Operation operation = math.Add;

        IAsyncResult result = operation.BeginInvoke(10, 5, null, null);
        int resultValue = operation.EndInvoke(result); // Очікуємо на завершення асинхронної операції

        Console.WriteLine($"Result: {resultValue}"); // Виведе: "Result: 15"



        // Приклад події з використанням делегатів:
        Button button = new Button();
        button.Click += HandleClick; // Підписка на подію
        button.OnClick(42); // Генерація події




        // Events
        TemperatureSensor sensor = new TemperatureSensor();
        sensor.TemperatureChanged += (sender, e) =>
        {
            Console.WriteLine($"Temperature changed: {e.NewTemperature}");
        };

        sensor.Temperature = 25.0; // Викличе подію
    }


    static void MyMethod(int x)
    {
        Console.WriteLine(x);
    }


    static void SomeOtherMethod(int x) => Console.WriteLine($"SomeOtherMethod: {x}");

    static void Hello() => Console.WriteLine("Hello METANIT.COM");



    // Функціональна програмування:
    static void PerformOperation(int a, int b, Func<int, int, int> operation)
    {
        int result = operation(a, b);
        Console.WriteLine($"Result: {result}");
    }


     // Асинхронна обробка
    public class MathOperations
        {
            public delegate int Operation(int a, int b);

            public int Add(int a, int b) => a + b;
            public int Subtract(int a, int b) => a - b;
            public int Multiply(int a, int b) => a * b;
            public int Divide(int a, int b) => a / b;
        }




    // Приклад події з використанням делегатів:

    class Button
    {
        public event MyDelegate Click; // Оголошення події з використанням делегата

        public void OnClick(int value)
        {
            if (Click != null)
                Click(value); // Виклик події
        }
    }


    static void HandleClick(int value)
    {
        Console.WriteLine("Button clicked with value: " + value);
    }



    // Events
    // Синтаксис оголошення події:
    public class Publisher
    {
        // Оголошення події
        public event EventHandler MyEvent;

        // Метод, що викликає подію
        public void RaiseEvent()
        {
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }


    // Обробка подій класу:

    public class TemperatureSensor
    {
        // Оголошення події
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        private double _temperature;

        public double Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    OnTemperatureChanged(new TemperatureChangedEventArgs(value));
                }
            }
        }

        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }

    public class TemperatureChangedEventArgs : EventArgs
    {
        public double NewTemperature { get; }

        public TemperatureChangedEventArgs(double newTemperature)
        {
            NewTemperature = newTemperature;
        }
    }

}
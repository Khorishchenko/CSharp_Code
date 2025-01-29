using System;

public class Indexers
{
    // public static void Main()
    // {

    // // Приклад використання індексатора
    //     MyCollection collection = new MyCollection();
    //     collection[0] = 10; // Встановлюємо значення першого елемента
    //     int value = collection[0]; // Отримуємо значення першого елемента


    // // Приклад використання багатовимірного індексатора
    //     Matrix matrix = new Matrix(3, 3);

    //     matrix[0, 0] = 1;
    //     matrix[0, 1] = 2;
    //     matrix[0, 2] = 3;

    //     matrix[1, 0] = 4;
    //     matrix[1, 1] = 5;
    //     matrix[1, 2] = 6;

    //     matrix[2, 0] = 7;
    //     matrix[2, 1] = 8;
    //     matrix[2, 2] = 9;

    //     // Отримуємо значення елемента за індексами
    //     Console.WriteLine(matrix[1, 1]); // Виведе 5
    // }

        // public Тип_елемента this[параметри_індекса]
        // {
        //     get
        //     {
        //         // Код для повернення значення елемента по індексу
        //     }
        //     set
        //     {
        //         // Код для встановлення значення елемента по індексу
        //     }
        // }

        class MyCollection
        {
            private int[] array = new int[10];

            public int this[int index]
            {
                get
                {
                    return array[index];
                }
                set
                {
                    array[index] = value;
                }
            }
        }


        // створення багатовимірних індексаторів;
        class Matrix
        {
            private int[,] matrix;

            public Matrix(int rows, int columns)
            {
                matrix = new int[rows, columns];
            }

            public int this[int row, int column]
            {
                get
                {
                    return matrix[row, column];
                }
                set
                {
                    matrix[row, column] = value;
                }
            }
        }
}
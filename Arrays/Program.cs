namespace Arrays;

internal class Program
{
    static void Main(string[] args)
    {
        // Инициализация пустого массива
        // Использовать, когда массив должен быть заполнен позже
        // Лучше использовать с var 
        //var numbers1 = new int[4];
        int[] numbers1 = new int[4];

        // Инициализация массива с автоматическим заполнением
        // Использовать, когда слева находится var
        // var numbers2 = new int[4] { 5, 8, 10, 0 };
        int[] numbers2 = new int[4] { 5, 8, 10, 0 };
        int[] numbers3 = new int[] { 5, 8, 10, 0 };
        int[] numbers4 = new[] { 5, 8, 10, 0 };

        // Так же инициализация массива с автоматическим заполнением
        // Но в этом случае var использовать не получится
        int[] numbers5 = { 5, 8, 10, 0 };
        // Рекомендуется использовать этот способ, если версия C# 12 и выше
        int[] numbers6 = [5, 8, 10, 0];


        // Получение элемента массива с помощью индекса
        // Результат: 10
        int number = numbers2[2];
        Console.WriteLine($"numbers[2] = {number}");

        // Изменение элемента массива
        // numbers2 = [100, 8, 10, 0]
        numbers2[0] = 100;


        // Использование массива может быть с любым типом данных
        DateTime[] dates = [DateTime.Now, DateTime.Today];
        string[] strings = new[] { "hello", "world", "!" };
        DayOfWeek[] weekends = { DayOfWeek.Saturday, DayOfWeek.Sunday };


        // Можно узнать длину массива используя соответствующее свойство
        int length = numbers1.Length;
        Console.WriteLine($"Длина массива number1: {length}");


        // Ручное заполнение массива из консоли
        for (int i = 0; i < numbers1.Length; i++)
        {
            Console.Write($"Введите элемент {i}: ");
            numbers1[i] = Convert.ToInt32(Console.ReadLine());
        }


        // Вывод всех элементов массива в консоль
        for (int i = 0; i < numbers1.Length; i++)
        {
            Console.WriteLine($"numbers1[{i}] = {numbers1[i]}");
        }



        // Многомерные массивы
        // Инициализация двумерного массива
        int[,] numbers2D = new int[3, 3]
        {
            { 5, 3, 2 },
            { 8, 0, 7 },
            { 3, 1, 1 }
        };


        // Получение элементов двумерного массива
        int num1 = numbers2D[0, 0]; // 5
        int num2 = numbers2D[1, 2]; // 7
        int num3 = numbers2D[2, 1]; // 1

        Console.WriteLine($"numbers2D[0, 0] = {num1}");
        Console.WriteLine($"numbers2D[1, 2] = {num2}");
        Console.WriteLine($"numbers2D[2, 1] = {num3}");


        // Инициализация трехмерного массива
        long[,,] numbers3D = new long[2, 2, 4]
        {
            {
                { 1, 2, 4, 6 },
                { 3, 4, 8, 1 }
            },
            {
                { 5, 6, 4, 0 },
                { 7, 8, 4, 6 }
            }
        };


        // Получение элементов трехмерного массива
        long num4 = numbers3D[0, 1, 2]; // 8
        long num5 = numbers3D[1, 0, 3]; // 0
        long num6 = numbers3D[1, 1, 1]; // 8

        Console.WriteLine($"numbers3D[0, 1, 2] = {num4}");
        Console.WriteLine($"numbers3D[1, 0, 3] = {num5}");
        Console.WriteLine($"numbers3D[1, 1, 1] = {num6}");


        // Получение ранга (измерения) массива
        int rank = numbers3D.Rank; // 3
        Console.WriteLine($"Ранг массива numbers3D: {rank}");


        // Получение общего количества элементов в массиве
        int totalLength = numbers3D.Length; // 16
        Console.WriteLine($"Общее количество элементов в массиве numbers3D: {totalLength}");


        // Получение длины массива по каждому измерению
        int length0 = numbers3D.GetLength(0); // 2
        int length1 = numbers3D.GetLength(1); // 2
        int length2 = numbers3D.GetLength(2); // 4

        Console.WriteLine($"Длина массива измерения 0: {length0}");
        Console.WriteLine($"Длина массива измерения 1: {length1}");
        Console.WriteLine($"Длина массива измерения 2: {length2}");


        // Ручное заполнение двумерного массива из консоли
        var array2D = new int[2, 3];

        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                Console.Write($"Введите элемент [{i}, {j}]: ");
                array2D[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        // Вывод всех элементов двумерного массива в консоль
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                Console.WriteLine($"array2D[{i}, {j}] = {array2D[i, j]}");
            }
        }
    }
}

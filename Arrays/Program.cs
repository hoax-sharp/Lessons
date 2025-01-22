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
    }
}

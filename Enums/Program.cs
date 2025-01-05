using Enums;

namespace Lessons.Enums
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Простое использование enum
            GameState gameState = GameState.Finished;

            if (gameState == GameState.Finished)
            {
                Console.WriteLine($"GameState = {gameState}. Игра окончена");
            }


            // Приведение значения enum к числу
            // Т.к. Finished = 4, то результат и будет 4
            int gameStateNumber = (int)gameState;
            Console.WriteLine($"Приведение {gameState} к числу, результат: {gameStateNumber}");


            // Приведение числа к enum
            // Результат: Paused
            int number = 3;
            gameState = (GameState)number;
            Console.WriteLine($"Приведение числа {number} к GameState, результат: {gameState}");


            // Приведение числа к несуществующему значению enum
            // Результат: 111
            number = 111;
            gameState = (GameState)number;
            Console.WriteLine($"Приведение числа {number} к несуществующему значению GameState, результат: {gameState}");


            // Проверяем определено ли приведенное значение enum в GameState (gameState = 111)
            // Результат: false
            if (Enum.IsDefined(gameState))
            {
                Console.WriteLine($"{gameState} определено в GameState");
            }
            else
            {
                Console.WriteLine($"{gameState} не определено в GameState");
            }

            // Проверяем опеределено ли число в GameState (number = 111)
            // Результат: false
            if (Enum.IsDefined(typeof(GameState), number))
            {
                Console.WriteLine($"Число {number} определено в GameState");
            }
            else
            {
                Console.WriteLine($"Число {number} не определено в GameState");
            }

            // Проверяем опеределена ли строка в GameState
            // Результат: true
            string gameStateString = "Running";
            if (Enum.IsDefined(typeof(GameState), gameStateString))
            {
                Console.WriteLine($"Строка {gameStateString} определена в GameState");
            }
            else
            {
                Console.WriteLine($"Строка {gameStateString} не определена в GameState");
            }


            // Получаем массив имен значений 
            // Результат: Started, Running, Paused, Finished
            string[] names = Enum.GetNames<GameState>();
            Console.WriteLine($"Имена значений: {string.Join(", ", names)}");


            // Получаем массив значений
            // Результат: Started, Running, Paused, Finished
            GameState[] values = Enum.GetValues<GameState>();
            Console.WriteLine($"Значения: {string.Join(", ", values)}");


            // Комбинация значений
            // Результат: Saturday, Sunday
            Days weekend = Days.Saturday | Days.Sunday;
            Console.WriteLine($"Комбинация значений enum: {weekend}");


            // Проверяем входит ли значение в комбинацию
            // Результат: true
            bool isDayWeekend = weekend.HasFlag(Days.Saturday);
            Console.WriteLine($"Входит ли значение {Days.Saturday} в {weekend}? {isDayWeekend}");


            // Пересечение значений или комбинаций значений
            // Результат: Thursday
            Days gymDays = Days.Monday | Days.Thursday;
            Days englishDays = Days.Thursday | Days.Sunday;
            Days overlap = gymDays & englishDays;
            Console.WriteLine($"Пересечение графиков занятий в зале и изучения английского: {overlap}");


            // Проверяем входит ли значение в комбинацию с использованием оператора пересечения вместо HasFlag()
            // Результат: true
            bool isDayWeekend2 = (weekend & Days.Saturday) == Days.Saturday;
            Console.WriteLine($"Входит ли значение {Days.Saturday} в {weekend}? {isDayWeekend2}");
        }
    }
}
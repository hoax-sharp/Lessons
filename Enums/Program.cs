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
        }
    }
}
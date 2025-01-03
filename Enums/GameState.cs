namespace Enums
{
    public enum GameState
    {
        // Started = 0
        Started,
        // Running = 0
        Running = Started,
        // Если бы не было указано значение явно, то было бы 1 
        Paused = 3,
        // Нумерация зависит от предыдущего значения, поэтому Finished = 4
        Finished
    }


    // Другой пример с использованием long, на случай если надо указать большие числа
    // long можно заменить на любой другой целочисленный тип данных (sbyte, short, uint и тд)
    // По умолчанию используется int
    public enum GameState2 : long
    {
        Started = 1000,
        Running = 1_000_000,
        Paused = 1_000_000_000,
        Finished = 1_000_000_000_000
    }
}

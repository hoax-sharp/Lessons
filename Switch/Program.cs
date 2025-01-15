using Enums;

namespace Switch;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 3;
        Operation operation = Operation.Multiplication;

        int result = 0;

        // Обработка множества условий с помощью if-else
        // Если operation имеет иное значение, чем указано в этом наборе условий,
        // то значение присвоенно не будет, а значит result опеределить наперед
        if (operation == Operation.Addition)
        {
            result = a + b;
        }
        else if (operation == Operation.Subtraction)
        {
            result = a - b;
        }
        else if (operation == Operation.Multiplication)
        {
            result = a * b;
        }
        else if (operation == Operation.Division)
        {
            result = a / b;
        }

        Console.WriteLine($"IF-ELSE. Результат операции {operation} между числами {a} и {b}: {result}");

        // Обработка тех же условий, но с помощью switch
        // Имеем бОльшую производительность, 
        // но пока остается та же проблема с присвоением result
        switch (operation)
        {
            case Operation.Addition:
                result = a + b;
                break;
            case Operation.Subtraction:
                result = a - b;
                break;
            case Operation.Multiplication:
                result = a * b;
                break;
            case Operation.Division:
                result = a / b;
                break;
        }

        Console.WriteLine($"SWITCH STATEMENT. Результат операции {operation} между числами {a} и {b}: {result}");


        // Примеры значений, которые можно использовать в case
        // Пример 1. Использование строки в виде литералов, что равно константе
        string str = "string";

        switch (str)
        {
            case "string":
                Console.WriteLine("some string");
                break;
        }

        // Пример 2. Использование числа в виде литерала, что так же будет константой
        int number1 = 5;

        switch (number1)
        {
            case 5:
                Console.WriteLine("Five");
                break;
        }

        // Пример 3. Создаем числовую константу в явном виде
        int number2 = 5;
        const int constNum = 5;

        switch (number2)
        {
            case constNum:
                Console.WriteLine("Five");
                break;
        }

        // Пример 4. Данный пример имеет ошибку, так как переменная nonConstNum не является константой.
        // Поэтому её использование в case недопустимо

        //int number3 = 5;
        //int nonConstNum = 5;

        //switch (number3)
        //{
        //    case nonConstNum:
        //        Console.WriteLine("Five");
        //        break;
        //}



        // Использование ключевого слова when - дополнительное условие
        // Код будет выполнен только тогда, когда и case, и when (если он есть) будут выполняться
        // Можно указать несколько одинаковых значений case, которые будут иметь разные условия в when
        // Использование одинаковых значений case БЕЗ when недопустимо, т.к. это создает неопределенность
        // Если условие case выполняется, то дальше будут последовательно проверяться условия when этих кейсов
        // Это значит, что case без when всегда должен быть после идентичных case с условиями when 
        DayOfWeek dayOfWeek = DayOfWeek.Monday;

        switch (dayOfWeek)
        {
            // К слову заданные таким образом значения enum так же считаются константой.
            // Если же значение enum перед этим записать в переменную и подставить сюда, то это будет ошибкой
            case DayOfWeek.Monday when DateTime.Now.Hour < 12:
                Console.WriteLine("Понедельник, время от 0 до 11");
                break;
            case DayOfWeek.Monday:
                Console.WriteLine("Понедельник, время от 12 до 23");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Вторник. Любое время");
                break;
        }


        // Использование default, что является аналогом else в кострукции if-else
        // Тут уже не было бы смысла присваивать значение наперед,
        // так как все случаи в данном switch будут покрыты
        switch (dayOfWeek)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Понедельник");
                break;
            default:
                Console.WriteLine("Любой день, кроме понедельника");
                break;
        }


        // Объединение случаев, если они должны выполнять один и тот же код
        switch (dayOfWeek)
        {
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                Console.WriteLine("Выходной");
                break;
            default:
                Console.WriteLine("Рабочий день");
                break;
        }


        // Использование switch expression, что является краткой формой switch statement
        // Имеет свои недостатки:
        //  1. Обязательно должен возвращать значения
        //  2. Должен покрывать все случаи
        //  3. В каждом случае может быть только одна строка
        result = operation switch
        {
            Operation.Addition => a + b,
            Operation.Subtraction => a - b,
            Operation.Multiplication => a * b,
            Operation.Division => a / b,
            _ => throw new Exception("Неправильная операция"),
        };

        Console.WriteLine($"SWITCH EXPRESSION. Результат операции {operation} между числами {a} и {b}: {result}");
    }
}
int[] inputBuffer = { };

void showHelp()
{
    Console.WriteLine("Нажмите 1 для выполнения команды 1: начать ввод элементов массива");
    Console.WriteLine("Нажмите 2 для выполнения команды 2: завершить ввод элементов массива и вывести результат");
    Console.WriteLine("Нажмите 3 для выполнения команды 3: задать параметры генерации массива случайных чисел и вывести результат");
}

void startInput()
{
    Console.WriteLine("Введите целое число что бы добавить элемент массива");
    Console.WriteLine("Что бы выйти из режима ввода массива нажмите Enter");
    while (true)
    {
        string? nextInput = Console.ReadLine();
        if (nextInput == "")
        {
            break;
        }
        int nextNumber;
        try
        {
            nextNumber = int.Parse(nextInput!.Replace(" ", ""));
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine($"Извините, не могу распознать число {nextInput}");
            continue;
        }
        catch (FormatException)
        {
            Console.WriteLine($"Извините, не могу распознать число {nextInput} ошибка формата");
            continue;
        }
        catch (OverflowException)
        {
            Console.WriteLine($"Извините, число {nextInput} выходит за рамки интервала {int.MinValue} .. {int.MaxValue}");
            continue;
        }
        // TODO: add nextNumber to the inputArray.
    }
}

void finishInput()
{
    Console.WriteLine("Комманда 2");
}

void randomTest()
{
    Console.WriteLine("Комманда 3");
}

Console.WriteLine("Программа предназначена для фильтрации массива целых чисел по критерию четности.");
showHelp();
while (true)
{
    string? nextInput = Console.ReadLine();
    if (nextInput == "1")
    {
        startInput();
    }
    else if (nextInput == "2")
    {
        finishInput();
    }
    else if (nextInput == "3")
    {
        randomTest();
    }
    else
    {
        showHelp();
    }
}

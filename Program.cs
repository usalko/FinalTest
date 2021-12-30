int[] inputBuffer = { };

void showHelp()
{
    string action = inputBuffer.Length > 0 ? "продолжить" : "начать";
    Console.WriteLine($"Нажмите 1 + Enter, для выполнения команды 1: {action} ввод элементов массива");
    Console.WriteLine("Нажмите 2 + Enter, для выполнения команды 2: завершить ввод элементов массива и вывести результат");
    Console.WriteLine("Нажмите 3 + Enter, для выполнения команды 3: задать параметры генерации массива случайных чисел и вывести результат");
    Console.WriteLine("Нажмите 4 + Enter, для выхода из программы");
}

int[] filterEvens(int[] array)
{
    int[] result = { };

    return result;
}

string arrayToString(int[] array)
{
    return "{" + String.Join(", ", array) + "}";
}

void startInput()
{
    Console.WriteLine($"Введите целое число что бы добавить элемент в массив {arrayToString(inputBuffer)}");
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
        Array.Resize(ref inputBuffer, inputBuffer.Length + 1);
        inputBuffer[inputBuffer.Length - 1] = nextNumber;
    }
}

void finishInput()
{
    Console.WriteLine("Входные данные");
    Console.WriteLine(arrayToString(inputBuffer));
    int[] resultArray = filterEvens(inputBuffer);
    Console.WriteLine("Выходные данные");
    Console.WriteLine(arrayToString(resultArray));
}

int getRandomArrayLengthFromInput()
{
    int result = 10;
    Console.WriteLine("Введите длину случайного массива целых чисел");
    while (true)
    {
        string? inputString = Console.ReadLine();
        try
        {
            result = int.Parse(inputString!.Replace(" ", ""));
            if (result <= 0)
            {
                Console.WriteLine($"К сожалению, длина массива должна быть положительным числом, больше нуля");
                continue;
            }
            break;
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine($"Извините, не могу распознать число {inputString}");
            continue;
        }
        catch (FormatException)
        {
            Console.WriteLine($"Извините, не могу распознать число {inputString} ошибка формата");
            continue;
        }
        catch (OverflowException)
        {
            Console.WriteLine($"Извините, число {inputString} выходит за рамки интервала {int.MinValue} .. {int.MaxValue}");
            continue;
        }
    }
    return result;
}

void randomTest()
{
    int inputBufferLength = getRandomArrayLengthFromInput();
    inputBuffer = new int[inputBufferLength];
    Random random = new Random();
    for (int i = 0; i < inputBufferLength; i++) {
        inputBuffer[i] = random.Next();
    }
    Console.WriteLine("Входные данные");
    Console.WriteLine(arrayToString(inputBuffer));
    int[] resultArray = filterEvens(inputBuffer);
    Console.WriteLine("Выходные данные");
    Console.WriteLine(arrayToString(resultArray));
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
    else if (nextInput == "4")
    {
        Console.WriteLine("Спасибо за использование приложения");
        break;
    }
    showHelp();
}

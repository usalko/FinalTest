void showHelp()
{
    Console.WriteLine("Нажмите 1 для выполнения команды 1: начать ввод элементов массива");
    Console.WriteLine("Нажмите 2 для выполнения команды 2: завершить ввод элементов массива и вывести результат");
    Console.WriteLine("Нажмите 3 для выполнения команды 3: задать параметры генерации массива случайных чисел и вывести результат");
}

void startInput()
{
    Console.WriteLine("Комманда 1");
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

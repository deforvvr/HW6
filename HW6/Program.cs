int taskNum;
Boolean begin = true;

int[] arrayInt = { };

while (begin)
{
    Console.Write("Введите номер задания >>> ");
    taskNum = int.Parse(Console.ReadLine());

    switch (taskNum)
    {
        case 41:
            Task41();
            break;

        case 43:
            Task43();
            break;

        default:
            begin = false;
            break;
    }
}


void Task41()
{
    Console.WriteLine("Введите любые числа разделённые любым знаком");
    int[] array = Array.ConvertAll(
        SortDigits(Console.ReadLine()).Split(" "), 
        int.Parse);

    int a = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) a++;
    }

    Console.WriteLine("Введено положительных чисел: " + a);
}

string SortDigits(string inputStr)
{
    int a;
    bool checkChar = true;

    for (int i = 0; i < inputStr.Length; i++)
    {
        if (int.TryParse(Convert.ToString(inputStr[i]), out a) || inputStr[i] == '-' && int.TryParse(Convert.ToString(inputStr[i + 1]), out a))
        {
            checkChar = false;
        }

        
        else
        {
            if (checkChar)
            {
                inputStr = inputStr.Remove(i, 1);
                checkChar = true;
                i--;
            }

            else
            {
                inputStr = inputStr.Remove(i, 1);
                inputStr = inputStr.Insert(i, " ");
                checkChar = true;
            }
        }
    }

    if (checkChar) inputStr = inputStr.Remove(inputStr.Length - 1, 1); 


    return inputStr;
}



void Task43()
{
    double k1, b1;
    double k2, b2;
    double resForX, resForY;

    Console.Write("Введите переменные для запрошенных уравнений >>> ");
    Console.WriteLine("y = k * x + b");

    Console.Write("k1 = ");
    k1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("b1 = ");
    b1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("k2 = ");
    k2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("b2 = ");
    b2 = Convert.ToDouble(Console.ReadLine());

    if (k1 != k2)
    {
        resForX = (b2 - b1) / (k1 - k2);
        resForY = k2 * resForX + b2;

        Console.Write("Координаты точки пересечения прямых >>> ");
        Console.WriteLine($"X = {resForX} ; Y = {resForY}");
    }

    else if (b1 == b2) Console.WriteLine("Прямые имеют одинаковые координаты");

    else Console.WriteLine("Прямые не пересекаются");
}
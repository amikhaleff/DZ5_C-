Console.Clear();
Console.Write("Введите номер порядковый номер задачи ");
int Task = int.Parse(Console.ReadLine() ?? "0");

if (Task == 1) ZADACHA_34();
else if (Task == 2) ZADACHA_36();
else if (Task == 3) ZADACHA_38();
else System.Console.WriteLine("Такой задачи нет в списке");


void ZADACHA_34()//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
{
    Console.Clear();

    int ReadData(string msg)// получение данных пользователя
    {
        System.Console.Write(msg);
        int number = int.Parse(System.Console.ReadLine() ?? "0");
        return number;
    }

    int[] Fill1DArray(int len) // заполнение массива трехзначными числами
    {
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            array[i] = new Random().Next(100, 1000);
        }
        return array;
    }

    int EvenNumArray(int[] array) //поиск четных элементов массива
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;


    }

    void Print1DArray(int[] array) //вывод данных в консоль
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            System.Console.Write(array[i] + ", ");
        }
        System.Console.WriteLine(array[array.Length - 1] + "]");

    }

    int arrayLen = ReadData("Введите длину массива ");
    int[] array = Fill1DArray(arrayLen);
    int evencount = EvenNumArray(array);
    Print1DArray(array);
    System.Console.WriteLine("Количество четных элементов массива равно: " + evencount);
}
void ZADACHA_36() //Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
{
    Console.Clear();

    int ReadData(string msg)
    {
        System.Console.Write(msg);
        int number = int.Parse(System.Console.ReadLine() ?? "0");
        return number;
    }

    int[] Fill1DArray(int len, int lowBord, int highBord)
    {
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            array[i] = new Random().Next(lowBord, highBord + 1);
        }
        return array;
    }

    int SumOddNumArray(int[] array) //сумма элементов массива нечетных индексов
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum = sum + array[i];
        }
        return sum;
    }

    void Print1DArray(int[] array)// вывод массива в консоль
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            System.Console.Write(array[i] + ", ");
        }
        System.Console.WriteLine(array[array.Length - 1] + "]");

    }

    int arrayLen = ReadData("Введите длину массива ");
    int lowBord = ReadData("Введите нижнюю границу массива: ");
    int highBord = ReadData("Введите верхнюю границу массива: ");
    int[] array = Fill1DArray(arrayLen, lowBord, highBord);
    int oddIndexSum = SumOddNumArray(array);
    Print1DArray(array);
    System.Console.WriteLine("Сумма нечетных элементов массива равна: " + oddIndexSum);
}
void ZADACHA_38()//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
{
    Console.Clear();

    int ReadData(string msg)
    {
        System.Console.Write(msg);
        int number = int.Parse(System.Console.ReadLine() ?? "0");
        return number;
    }

    double[] Fill1DArray(int len, int lowBord, int highBord)
    {
        double[] array = new double[len];
        Random r = new Random();

        for (int i = 0; i < len; i++)
        {
            array[i] = Math.Round((r.NextDouble() * 10), 2);// заполнение массива вещественными числами
        }              //округление                //двух знаков после,                
        return array;
    }

    double DiffMaxMinNumArray(double[] array)
    {
        double min = array.Min(); //операции библиотеки Linq (Min(),Max(),Average())
        double max = array.Max();//
        double diff = max - min;

        return diff;
    }

    void Print1DArray(double[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            System.Console.Write(array[i] + ", ");
        }
        System.Console.WriteLine(array[array.Length - 1] + "]");

    }

    int arrayLen = ReadData("Введите длину массива ");
    int lowBord = ReadData("Введите нижнюю границу массива: ");
    int highBord = ReadData("Введите верхнюю границу массива: ");
    double[] array = Fill1DArray(arrayLen, lowBord, highBord);
    double diff = DiffMaxMinNumArray(array);
    Print1DArray(array);
    Console.WriteLine("Разность между макс и мин элементами массива равна: " + Math.Round((diff), 2));
}






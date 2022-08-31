/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
void powNumber()
{
    while (true)
    {
        Console.Write("Введите число: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите степень в которое необходимо возвести число: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Для дальнейшего выхода введите 'q': ");  
        string quit = Console.ReadLine().ToLower();
        Console.WriteLine($"число {firstNumber} в степени {secondNumber} = {Math.Pow(firstNumber, secondNumber)}");
        if (quit == "q") break;
    }
}
try
{
    Console.WriteLine("Задача 1");
    powNumber();
}
catch (System.Exception)
{
    Console.WriteLine("Вводите целый числа");
}

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int sumNumbersInNumber(int number)
{
    int sum = 0;
    List<int> listOfInts = new List<int>();
    while(number > 0)
    {
        listOfInts.Add(number % 10);
        number /= 10;
    }
    foreach (var item in listOfInts)
    {
        sum += item;
    }
    return sum;
}
try
{
    Console.WriteLine("Задача 2");
    Console.Write("Введите, для вычесления суммы цифр число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма цифр вашего числа {number} = {sumNumbersInNumber(number)}");   
}
catch (System.Exception)
{
    Console.WriteLine("Вводите целый числа");
}
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
string getArray()
{
    Console.Write("Введите числа, которые необходимо добавить в массив через пробел: ");
    string arrayNumber = Console.ReadLine();
    var array = arrayNumber.Split(' ').Select(Int32.Parse).ToArray();
    string arrayString = string.Empty;
    foreach (var item in array)
    {
        arrayString += item + " "; 
    }
    return arrayString;
}
try
{
    Console.WriteLine("Задача 3");
    Console.WriteLine($"Ваш список = [{getArray()}]");
}
catch (System.Exception)
{
    
    Console.WriteLine("Необходимо вводить целые числа, также числа должны быть разделены пробелом");
}
/*
необязательная задача
Написать программу, которая сортирует массив от большего к меньшему и находит медианное значение. 
Массив заполняется случайными целыми числами от 1 до 100, а его размерность вводится с клавиатуры.
*/
int[] returnArray(int finalNumb)
{
    int[] array = new int[finalNumb];
    for (int i = 0; i < finalNumb; i++)
    {
        array [i] = new Random().Next(0, 100);
        Console.Write(array [i]+ " ");
    }

    string arrayString = string.Empty;
    for (int i = 0; i < finalNumb; i++)
    {
        for (int a = i; a < finalNumb; a++)
        {
            if (array[i]<array[a])
            {
                int dump = array[i];
                array[i] = array[a];
                array[a] = dump;
            }
        }
        arrayString += array[i] + " "; 
    }
    Console.WriteLine("\nОтсортированный список по убыванию массив\n" + arrayString);
    double mediana = 0;
    if (finalNumb%2==0)
    {
        mediana = (Convert.ToDouble(array[finalNumb/2])+Convert.ToDouble(array[finalNumb/2-1]))/2;
    }
    else
    {
        mediana = array[finalNumb/2];        
    }
    Console.WriteLine("Медиана = " + mediana);  
    return array;
}
try
{
    Console.WriteLine("Дополнительное задание");
    Console.Write("Введите количество элементов массива: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] rndArray = returnArray(N);
}
catch (System.Exception)
{
    Console.WriteLine("Вводите целый числа");
}

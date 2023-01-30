// Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное

// 1. Ввод N
int GetNumber (string text)
{
    Console.Write(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

// 2. Создание массива
int[] Array(int array)
{
    return new int[array];
}

// 3. Заполнение массива 0 и 1
void GetArray(int[] Number)
{
    int count = Number.Length;

    for (int i = 0; i < count; i++)
    {
        Number[i] = new Random().Next(0, 1);
    }
}

// 4. Печать массива
string PrintArray(int[] numbers)
{
    string output = String.Empty;
    int size = numbers.Length;

    for (int i = 0; i < size; i++)
    {
        output = output + $"{numbers[i]} ";
    }
    return output;
}

// 5. Конвертация из 2-ого в 10-ое
int ChangeNumber(int[] col)
{
    int index = col.Length;
    int degree = col.Length - 1;
    int result = 0;

    for (int i= 0; i < col.Length; i++)
    {
        result = result + Convert.ToInt32(Math.Pow(2, degree));
        degree --;
    }
    return result;
}

// 6. 10110100 >> 180

string GoodPrint(int[] bin, int dec)
{
return $"\n{String.Join("", bin)} >> {dec}";
}

int [] array = {1, 0, 1, 1, 0, 1, 0, 0};
int result = ChangeNumber(array);
string Print = PrintArray(array);
Console.Write(Print);
Console.WriteLine(GoodPrint(array, result));



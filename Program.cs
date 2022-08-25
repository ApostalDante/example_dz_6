/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

/* - решение - */

Console.Clear();

//создание и запись чисел в массив
int[] CreateArrNumbers()
{
    Console.Write("Введите количество элементов массива:\t");
    int elementsCount = int.Parse(Console.ReadLine());
    while (elementsCount <= 0 || elementsCount > 20)
    {
        Console.WriteLine("Только положительные числа, не больше 20");
        Console.Write("Введите количество элементов массива:\t");
        elementsCount = int.Parse(Console.ReadLine());
    }

    int[] arr = new int[elementsCount];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}
// Подсчитывает сколько чисел больше 0 ввёл пользователь.
int СalkPositiveNumbers(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            summ++;
        };
    };
    return summ;
};

int[] array = CreateArrNumbers();
Console.WriteLine($"Чисел больше 0, пользователь ввёл: {СalkPositiveNumbers(array)}");

/*--------------------------------------------------------------------------------------*/

/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/* - решение - */

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

//ввод значений
void InputCoefficients()
{
    for (int i = 0; i < coeff.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < coeff.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            coeff[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

//вычисляет координаты точек пересечения
double[] CoordinateCalk(double[,] coeff)
{
    crossPoint[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
    crossPoint[1] = crossPoint[0] * coeff[0, 0] + coeff[0, 1];
    return crossPoint;
}

//показывает результат
void ShowOutputResponse(double[,] coeff)
{
    if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] == coeff[1, 1])
    {
        Console.WriteLine($"\nПрямые совпадают");
    }
    else if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] != coeff[1, 1])
    {
        Console.WriteLine($"\nПрямые параллельны");
    }
    else
    {
        CoordinateCalk(coeff);
        Console.WriteLine($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputCoefficients();
ShowOutputResponse(coeff);

/*--------------------------------------------------------------------------------------*/

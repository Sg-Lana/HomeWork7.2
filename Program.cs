/* Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет*/

int [,] CreateArray(int lenRows, int lenColumns)// метод для создания двумерного массива
{
    int [,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++) // генерация строк
    {
        for (int j = 0; j < array.GetLength(1); j++) // генерация столбцов
        {
            array[i, j] = random.Next(-5, 6); // задали диапазон элементов массива
        }
    }
    return array; 
}

void PrintArray(int[,] array) // метод для вывода массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine(); // переход на следующую строку,пустая строка
    }
}

int PromptStr()// метод для ввода данных, строки
{
    System.Console.WriteLine("введите номер строки - ");
    int line = Convert.ToInt32(Console.ReadLine());
    return line;
}

int PromptCol()// метод для ввода данных, столбца
{
    System.Console.WriteLine("введите номер столбца - ");
    int column = Convert.ToInt32(Console.ReadLine());
    return column;
}

bool SearchNumberInMatrix(int line, int column,int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        if (array[line,column]==array [i,j])
        {
            System.Console.WriteLine(array [i,j]);
            return true;
        }
       } 
    }
    return false;
}


int [,] array = CreateArray(4, 5);// вызываем метод для генерации массива с параметрами 4 строки и 5 толбцов
PrintArray(array);// выводим массив на эран
int line = PromptStr();// задаем параметры, просим пользователя указать номер строки
int column = PromptCol();// задаем параметры, просим пользователя указать номер столбца

//if(line < 0 || column < 0 || line > array.GetLength(0)-1 || column > array.GetLength(0)-1)
if (array[line, column] !=SearchNumberInMatrix())
{
    System.Console.WriteLine($"{line},{column} -> числа по заданным параметрам нет");
}
else
{
    System.Console.WriteLine($"{line}, {column} -> ");
    int result = SearchNumberInMatrix(line, column, array);
    System.Console.WriteLine(result);
}
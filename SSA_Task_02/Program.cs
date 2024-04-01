using System;

class Program
{
    static bool ПолеБелоеОлиЧерноеЕсть(int x, int y)
    {
        // Проверяем, находится ли поле на четной строке
        if (y % 2 == 0)
        {
            // Поля на четных строках имеют черный цвет, если x также четное
            return x % 2 == 0;
        }
        else
        {
            // Поля на нечетных строках имеют черный цвет, если x нечетное
            return x % 2 != 0;
        }
    }

    static void ОтрисоватьДоску()
    {
        Console.WriteLine("  a b c d e f g h");

        for (int y = 8; y >= 1; y--)
        {
            Console.Write(y + " ");
            for (int x = 1; x <= 8; x++)
            {
                if (ПолеБелоеОлиЧерноеЕсть(x, y))
                {
                    Console.Write("□ ");
                }
                else
                {
                    Console.Write("■ ");
                }
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        // Отрисовываем шахматную доску
        ОтрисоватьДоску();

        // Получаем координаты первого поля
        Console.Write("Введите координату x первого поля (от 1 до 8): ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату y первого поля (от 1 до 8): ");
        int y1 = Convert.ToInt32(Console.ReadLine());

        // Получаем координаты второго поля
        Console.Write("Введите координату x второго поля (от 1 до 8): ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату y второго поля (от 1 до 8): ");
        int y2 = Convert.ToInt32(Console.ReadLine());

        // Проверяем цвета полей
        bool первоеПолеБелое = ПолеБелоеОлиЧерноеЕсть(x1, y1);
        bool второеПолеБелое = ПолеБелоеОлиЧерноеЕсть(x2, y2);

        // Выводим результат
        if (первоеПолеБелое == второеПолеБелое)
        {
            Console.WriteLine("Поля одного цвета.");
        }
        else
        {
            Console.WriteLine("Поля разного цвета.");
        }
    }
}
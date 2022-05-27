using System;

namespace progressions
{
    class Program
    {
        static void Main(string[] args)
        {
            IProgression progression;

            Console.Write("Введите первое число: ");
            int first_number_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите разность арифметической прогрессии: ");
            int d_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите n число: ");
            int n_1 = Convert.ToInt32(Console.ReadLine());

            progression = new ArithmeticProgression(first_number_1, d_1);

            Console.WriteLine($"Арифметическая прогрессия: {progression.GetElement(n_1)}");
            Console.WriteLine($"Cумма арифметическая прогрессия: {progression.SumElement(n_1)}\n");

            Console.Write("Введите первое число: ");
            int first_number_2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите разность геометрической прогрессии: ");
            int d_2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите n число: ");
            int n_2 = Convert.ToInt32(Console.ReadLine());

            progression = new GeometricProgression(first_number_2, d_2);

            Console.WriteLine($"Геометрическая прогрессия: {progression.GetElement(n_2)}");
            Console.WriteLine($"Сумма Геометрической прогрессии:{progression.SumElement(n_2)}");
        }
    }
}

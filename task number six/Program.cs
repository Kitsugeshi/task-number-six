using System;
using System.Diagnostics;
using System.Numerics;

namespace task_number_six
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            while (true)
            {

                Console.WriteLine("Введите число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                stopWatch.Start();
                var res = Recursia(n);
                stopWatch.Stop();
                Console.WriteLine("Обычный цикл. Прошло времени: " + stopWatch.Elapsed);
                stopWatch.Restart();
                var res1 = SimpleFactorial(n);
                stopWatch.Stop();
                Console.WriteLine("Рекурсия. Прошло времени: " + stopWatch.Elapsed);
                Console.WriteLine(res);
                Console.WriteLine(res1);
            }

        }
        static BigInteger Recursia(int x)
        {
            BigInteger result = BigInteger.One;
            for (int i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
        static BigInteger SimpleFactorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            return x * SimpleFactorial(--x);
        }
    }
}
// Вывод:
// 1. Рекурсивный факториал имеет меньшую область значений, но выполняет вычисление быстрее при небольших вводимых даннх. Однако потом факториал цикличный выполняет задачу быстрее.
// 2. Цикличный факториал эффективнее рекурсивного за счёт большей области значений.
// 3. Рекурсивный факториал выглядит проще, чем цикличный.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            bool isCorrect = true;
            
            do
            {
                Console.WriteLine("Какую математическую операцию необходимо произвести?");
                Console.WriteLine("1 - Арифметическая прогрессия");
                Console.WriteLine("2 - Геометрическая прогрессия");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите число");
                            arith.SetStart(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("Введите значение шага арифметической прогрессии");
                            arith.setStep(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("Введите значение количество шагов арифметической прогрессии");
                            arith.numberStep(Convert.ToInt32(Console.ReadLine()));
                            arith.NStep();
                            Console.WriteLine();

                            Console.WriteLine("Выполнить новый расчет или выключить программу?");
                            Console.WriteLine("y - Выполнить новый расчет");
                            Console.WriteLine("Любая другая клавиша - Закрыть программу");
                            string choise = Console.ReadLine();
                            
                            if (choise == "y")
                            { 
                                isCorrect = true;
                                arith.Reset();
                                Console.Write("Значение сброшено до стартового значения = ");
                                arith.ShowStart();
                                Console.WriteLine();
                            }

                            else
                            {
                                isCorrect = false;
                            }

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите число");
                            arith.SetStart(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("Введите значение шага арифметической прогрессии");
                            arith.setStep(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("Введите значение количество шагов арифметической прогрессии");
                            arith.numberStep(Convert.ToInt32(Console.ReadLine()));
                            arith.NStep2();
                            Console.WriteLine();

                            Console.WriteLine("Выполнить новый расчет или выключить программу?");
                            Console.WriteLine("Y - Выполнить новый расчет");
                            Console.WriteLine("Любая другая клавиша - Закрыть программу");
                            string choise = Console.ReadLine();

                            if (choise == "y")
                            {
                                isCorrect = true;
                                arith.Reset();
                                Console.Write("Значение сброшено до стартового значения = ");
                                arith.ShowStart();
                                Console.WriteLine();
                            }

                            else
                            {
                                isCorrect = false;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка выбора");
                            break;
                        }

                }
            }
            while (isCorrect == true);
            
            Console.ReadKey();

        }
    }
}

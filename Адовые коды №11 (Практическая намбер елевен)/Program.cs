using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ИСП-23, Бирюков Георгий, 16.12.21
//Дано n независимых случайных точек, с координатами (xi; yi), равномерно распределенных в круге радиуса R с центром в начале координат. 
//Напишите программу, располагающую точки в порядке возрастания расстояния от центра.

namespace Адовые_коды__11__Практическая_намбер_елевен_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,
n;
            Console.WriteLine("Введите количество точек");
            x = Convert.ToInt32(Console.ReadLine()); // Ввод количества точек
            int[] masos = new int[x]; // Ввод массива
            int[] masosus = new int[x]; // Ввод массива
            Random randomus = new Random(); // Ввод рандома

            /// Присваивание значения точкам + вывод начальных точек
            for (int i = 0; i < x; i++)
            {
                masos[i] = randomus.Next(-5, 5);
                masosus[i] = randomus.Next(-5, 5);
                Console.WriteLine("(" + masos[i].ToString() + ";" + masosus[i] + ")");
            }
            Console.WriteLine("new");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x - 1; j++)
                {
                    if (Math.Abs(masos[j]) + Math.Abs(masosus[j]) > Math.Abs(masos[j + 1]) + Math.Abs(masosus[j + 1]))
                    {
                        /// Условие выполнения сортировки ( пузырьковая )
                        if (Math.Abs(masos[j]) > Math.Abs(masos[j + 1]) || Math.Abs(masosus[j]) > Math.Abs(masosus[j + 1]))
                        {
                            n = masos[j + 1];
                            masos[j + 1] = masos[j];
                            masos[j] = n;

                            n = masosus[j + 1];
                            masosus[j + 1] = masosus[j];
                            masosus[j] = n;
                        }
                    }
                }
            }

            /// Вывод отсортированных точек
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("(" + masos[i].ToString() + ";" + masosus[i] + ")");
            }
            Console.ReadKey(); // Пауза
        }
    }
}

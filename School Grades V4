using System;

namespace _3D_Arrays
{
    public class Program
    {
        public static void Main()
        {
            int[,,] array3D = new int[1, 4, 12] { { { 4, 5, 6, 4, 5, 3, 4, 4, 3, 5, 5, 5 }, { 4, 4, 5, 3, 3, 5, 6, 6, 6, 4, 3, 4 }, { 3, 6, 4, 5, 6, 3, 4, 6, 6, 6, 4, 5 }, { 5, 4, 5, 5, 4, 6, 3, 4 , 6, 5, 4, 4 } } };

            int g = 2016; //Стартова година
            int kl = 7; //Стартов клас
            string[] Subjects; //Задаване на предмети
            Subjects = new string[12] { "Математика               |           ", "Български                |           ", "История                  |           ", "География                |           ", "Философия                |           ", "Химия                    |           ", "Информационни Технологии |           ", "Информатика              |           ", "Музика                   |           ", "Руски Език               |           ", "Английски Език           |           ", "Физическо                |           " };
            double avrg = 0; //Добавяне на променлива за запазване на средните числа
            for (int i = 0; i < 1; i++)

            {
                for (int j = 0; j < 4; j++)

                {
                    int god = g + j; //Години
                    int kla = kl + j; //Класове
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("             " + god + "г - " + "Клас " + kla);
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine();
                    avrg = 0;
                    for (int k = 0; k < 12; k++)

                    {
                        Console.Write(Subjects[k], array3D[0, 0, 0]);
                        Console.WriteLine("- {3}", i, j, k, array3D[i, j, k]);
                        avrg += array3D[i, j, k]; //Събиране на стойности
                    }
                    avrg = avrg / array3D.GetLength(2); //Смятане на средните стойности
                    Console.WriteLine();
                    Console.WriteLine("Годишна Оценка: {0}", Math.Round(avrg)); //Изкарване на средния резултат
                    Console.WriteLine();
                }
            }
			
			Console.WriteLine("Код написан от Пламен Петров");
        }
    }
}

/// Tools/Options/Text Editor and uncheck "Follow project coding conventions"

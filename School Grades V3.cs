using System;

namespace _3D_Arrays
{
    public class Program
    {
        public static void Main()
        {

            int[,,] array3D = new int[1, 4, 3] { { { 4, 5, 6 }, { 4, 4, 5 }, { 3, 6, 4 }, { 5, 4, 5 } } }; //Оценки
            Console.WriteLine("------------ School Grades: ------------");
            Console.WriteLine();
			int g = 2016; //Стартова година
			int kl = 7; //Стартов клас
			string[] Subjects; //Задаване на предмети
			Subjects = new string[3]{ "Mathematics", "Bulgarian  ", "History    "};

            for (int i = 0; i < 1; i++) //Брой обиколки на масива

            {
                for (int j = 0; j<4; j++)//Брой години

                {
					int god = g + j; //Години
                    int kla = kl + j; //Класове
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("             " + god + " - " + "Grade " + kla );
                    Console.WriteLine("----------------------------------------");

                    for (int k = 0; k < 3; k++) //Оценки

                    { //Резултат
                        Console.Write( Subjects[k] ,array3D[0,0,0]); 
						Console.WriteLine(": {3}", i, j, k, array3D[i,j,k]);
                    }
                }
            }
            { 
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(); //Лого
            Console.WriteLine("        :::::::::  :::            :::       :::   :::   :::::::::: ::::    ::: ");
            Console.WriteLine("       :+:    :+: :+:          :+: :+:    :+:+: :+:+:  :+:        :+:+:   :+: ");
            Console.WriteLine("      +:+    +:+ +:+         +:+   +:+  +:+ +:+:+ +:+ +:+        :+:+:+  +:+   ");
            Console.WriteLine("     +#++:++#+  +#+        +#++:++#++: +#+  +:+  +#+ +#++:++#   +#+ +:+ +#+    ");
            Console.WriteLine("    +#+        +#+        +#+     +#+ +#+       +#+ +#+        +#+  +#+#+# ");
            Console.WriteLine("   #+#        #+#        #+#     #+# #+#       #+# #+#        #+#   #+#+#      ");
            Console.WriteLine("  ###        ########## ###     ### ###       ### ########## ###    ####       ");
            Console.ReadLine();
            }
        }
    }
}

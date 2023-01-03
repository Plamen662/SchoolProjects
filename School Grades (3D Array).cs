using System;

namespace _3D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,,] array3D = new int[1, 4, 3] { { { 4, 5, 6 }, { 4, 4, 5 }, { 3, 6, 4 }, { 5, 4, 5 } } };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------ School Grades: ------------");
            Console.WriteLine();

            for (int i = 0; i < 1; i++)

            {
                for (int j = 0; j<4; j++)

                {
                    int g = 2016;
                    int kl = 7;
                    int kla = kl + j;
                    int god = g + j;
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("             " + god + " - " + "Grade " + kla );
                    Console.WriteLine("----------------------------------------");

                    for (int k = 0; k < 3; k++)

                    {
                        Console.WriteLine("- Subject[{2}] : {3}", i, j, k, array3D[i,j,k]);
                    }
                }
            }
            { 
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("  0 = Math, 1 = Bulgarian, 2 = History");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
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

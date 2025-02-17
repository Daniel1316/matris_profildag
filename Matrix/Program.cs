﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixVerifyer;

namespace Matrix
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /*
             * Där finns tester tillgängliga genom att skriva
             * MatrixChecker.CheckAddition
             * MatrixChecker.CheckMultiplication
             * MatrixChecker.CheckRotationMatrix
             * 
             * Observera att testerna inte är noga testade.
             * 
             * De tar emot argument enligt följande standard:
             * CheckAddition tar emot alla Matris-värden 00, 01, 10, 11 för matris A
             * och alla Matris-värden 00, 01, 10, 11 för matris B, och den sista är
             * då det uträknade resultatet av A + B, som då är en matris 00, 01, 10, 11
             * 
             * CheckMultiplication liknar CheckAddition, den tar emot tre matriser,
             * A, B och sedan resultatet av A * B. Sen kommer den att jämföra och se
             * ifall matrisen har blivit rätt
             * 
             * CheckRotationMatrix tar emot antalet radianer du roterat en matris av,
             * och sedan en rotationsmatris som du har skapat. Den jämför sedan värden
             * för att se ifall matriserna stämmer överens.
             */

            /*
             * Där finns ett inbyggt verktyg för att rita ut matriser i två format.
             * Den första tar emot alla matrisvärden, 00, 01, 10, 11 och den andra
             * tar emot en float[,] (en float 2D-array) och skriver sedan ut matrisen
             * formaterat, och endast med 2 decimaler.
             */

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A + B
            // Exempel: MatrixChecker.CheckAddition(1, 2, 3, 4, 1, 2, 3, 4, 2, 4, 6, 8);

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A * B
            // Exempel: MatrixChecker.CheckMultiplication(1, 2, 3, 4, 1, 2, 3, 4, 7, 10, 15, 22);


            // Byt ut detta anropet med dina matrisvärden, så kommer programmet att rita ut dem istället :)

            float a00=1, a01=2, a10=3, a11=4, b00=5, b01=6, b10=7, b11=8, c00 = a00 + b00, c01 = a01 + b01, c10 = a10 + b10, c11 = a11 + b11;


            Draw2x2Matrix(a00, a01, a10, a11);
            Console.WriteLine("\n+");
            Draw2x2Matrix(b00, b01, b10, b11);
            Console.WriteLine("\n=");
            Draw2x2Matrix(c00, c01, c10, c11);
            Console.WriteLine();
            MatrixChecker.CheckAddition(a00, a01, a10, a11, b00, b01, b10, b11, c00, c01, c10, c11);

            //

            float radians = 3.14f;

            double dm00 = radians;
            double dm01 = radians;

            dm00 = Math.Cos(dm00);
            dm01 = Math.Sin(dm01);

            float m00 = (float)dm00;
            float m01 = (float)dm01;
            float m10 = (float)-dm01;
            float m11 = (float)dm00;

            Draw2x2Matrix(m00, m01, m10, m11);
            Console.WriteLine();
            MatrixChecker.CheckRotationMatrix(radians, m00, m01, m10, m11);

            //

            c00 = a00 * b00 + a01 * b10; c01 = a00 * b01 + a01 * b11; c10 = a10 * b00 + a11 * b10; c11 = a10 * b01 + a11 * b11;

            Draw2x2Matrix(a00, a01, a10, a11);
            Console.WriteLine("\n*");
            Draw2x2Matrix(b00, b01, b10, b11);
            Console.WriteLine("\n=");
            Draw2x2Matrix(c00, c01, c10, c11);
            Console.WriteLine();
            MatrixChecker.CheckAddition(a00, a01, a10, a11, b00, b01, b10, b11, c00, c01, c10, c11);

            //

            Console.WriteLine("set your own matris");
            string sa00, sa01, sa10, sa11, sb00, sb01, sb10, sb11;
            sa00 = Console.ReadLine(); sa01 = Console.ReadLine(); sa10 = Console.ReadLine(); sa11 = Console.ReadLine(); sb00 = Console.ReadLine(); sb01 = Console.ReadLine(); sb10 = Console.ReadLine(); sb11 = Console.ReadLine();
            a00 = float.Parse(sa00); a01 = float.Parse(sa01); a10 = float.Parse(sa10); a11 = float.Parse(sa11); b00 = float.Parse(sb00); b01 = float.Parse(sb01); b10 = float.Parse(sb10); b11 = float.Parse(sb11);

            c00 = a00 * b00 + a01 * b10; c01 = a00 * b01 + a01 * b11; c10 = a10 * b00 + a11 * b10; c11 = a10 * b01 + a11 * b11;

            Draw2x2Matrix(a00, a01, a10, a11);
            Console.WriteLine("\n*");
            Draw2x2Matrix(b00, b01, b10, b11);
            Console.WriteLine("\n=");
            Draw2x2Matrix(c00, c01, c10, c11);
            Console.WriteLine();
            MatrixChecker.CheckAddition(a00, a01, a10, a11, b00, b01, b10, b11, c00, c01, c10, c11);

            Console.ReadKey();
        }
    }
}

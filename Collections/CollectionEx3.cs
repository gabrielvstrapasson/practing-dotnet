using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioColecoes.Collections
{
    /* 
     3-Escreva um programa em C# que solicite ao usuário que 
    informe o valor das notas, do tipo float , para 10 alunos 
    divididos em 2 grupos de 5 alunos cada. 
    Armazene as informações em um array bidimensional e a
    seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).
    */
    internal class CollectionEx3
    {

        public static void AverageInGroups()
        {
            float[,] grades = new float[2, 5];


            for (int i = 0; i < grades.GetLength(0); i++)
            {
                float sumGrade = 0.0f;
                Console.WriteLine($"Informe as notas do grupo {i + 1}: ");

                for (int j = 0; j < grades.GetLength(1); j++)
                {
                    grades[i, j] = float.Parse(Console.ReadLine()!);
                    sumGrade += grades[i, j];
                }

                var AverageGrade = sumGrade / grades.GetLength(1);
                Console.WriteLine($"A média do grupo {i + 1} é: {AverageGrade}");
            }
        }
    }
}

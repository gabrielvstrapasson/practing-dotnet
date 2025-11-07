using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

/* 
 

*/
namespace ExercicioColecoes.Collections
{
    public static class CollectionEx2
    {
        public static void SearchInArray()
        {

            int maxNumberInArray = 0, numberToSearch = 0;

            Console.WriteLine("Informe a quantidade de números que deseja inserir no array: ");
            maxNumberInArray = int.Parse(Console.ReadLine()!);

            int[] numbersArray = [maxNumberInArray];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine("Digite o valor a ser inserido no array [INT]: ");
                numbersArray.Append(int.Parse(Console.ReadLine()!));
            }

            Console.WriteLine("Informe qual número deseja verificar se existe no array: ");
            numberToSearch = int.Parse(Console.ReadLine()!);

            if (numbersArray.Contains(numberToSearch))
            {
                Console.WriteLine("O valor existe no array.");
            }
            else
            {
                Console.WriteLine("O valor não existe no array.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

/* 
 2- Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas
etapas a seguir
b- Exiba os nomes da segunda e da penúltima fruta no console
a-) Solicite via teclado o número de valores do array (deve ser um número inteiro)
b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
c-) Solicite ao usuário um valor de um número inteiro a procurar no array
d-) Exiba se o número informado existe no array de inteiros ou não
e-) Repita até que o texto ‘fim’ seja inserido via teclado

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
1- Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora
a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
b- Exiba os nomes da segunda e da penúltima fruta no console
c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
d- Ordene a coleção de frutas na ordem ascendente
e- Exiba no console a coleção de nomes de frutas na ordem inversa
*/
namespace ExercicioColecoes.Collections
{
    public class CollectionEx1
    {
        public static void OperationsInArray()
        {

            string[] frutas = ["Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"];

            Console.WriteLine("Foreach: ");
            foreach (var fruta in frutas)
            {
                Console.WriteLine($" Fruta: {fruta}: ");
            }

            Console.WriteLine($"Quantidade de frutas: {frutas.Count()}");

            Console.WriteLine();

            Console.WriteLine("For: ");

            for (int i = 0; i < frutas.Count(); i++)
            {
                Console.WriteLine($"Fruta: {frutas[i]}");
            }



            Console.WriteLine($"Segunda fruta: {frutas[1]}, Penultima Fruta {frutas[frutas.Length - 2]}");

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Alterando valores do array: ");
            frutas.SetValue("Kiwi", 2);
            frutas.SetValue("Caqui", 9);

            foreach (var fruta in frutas)
            {
                Console.WriteLine($"Fruta: {fruta}");
            }

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine($"Frutas ordenadas: ");

            Array.Sort(frutas);

            foreach (var fruta in frutas)
            {
                Console.WriteLine($"Fruta: {fruta}");
            }

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Ordem inversa do array: ");

            Array.Reverse(frutas);


            foreach (var fruta in frutas)
            {
                Console.WriteLine($"Fruta: {fruta}");
            }
        }

    }
}

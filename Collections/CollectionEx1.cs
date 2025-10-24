using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



            Console.WriteLine($"Segunda fruta: {frutas[1]}, Penultima Fruta {frutas[8]}");

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

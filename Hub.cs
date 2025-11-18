using ExercicioColecoes.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExercicioColecoes
{
    internal class Hub
    {

        public static void HubOptions()
        {
            Console.WriteLine("Selecione a opção que deseja visualizar o exercício: ");
            Console.WriteLine("1 - Collections Exercises");
            Console.WriteLine("2 - Herança");
            Console.WriteLine("0 - Leave");

            switch (Console.ReadLine())
            {
                case "0":
                    Console.WriteLine("Saindo..");
                    break;

                case "1":
                    CollectionsHub();
                    break;
            }


        }



        internal static void CollectionsHub()
        {
            Console.WriteLine("Escolha qual exercicio das Collections deseja ver: ");
            Console.WriteLine("1 - Array Frutas - Modificando Array e imprimindo de maneiras diferentes");
            Console.WriteLine("2 - Pesquisa no Array");
            Console.WriteLine("3 - List<T>");
            Console.WriteLine("4 - Media em Grupos");
            Console.WriteLine("0 - Leave");
            switch (Console.ReadLine())
            {
                case "0":
                    HubOptions();
                    break;

                case "1":
                    ExercicioListT.PrintInformationsAboutStudent();
                    break;

                case "2":
                    Collections.CollectionEx1.OperationsInArray();
                    break;

                case "3":
                    Collections.CollectionEx2.SearchInArray();
                    break;

                case "4":
                    CollectionEx3.AverageInGroups();
                    break;

            }
        }


    }
}

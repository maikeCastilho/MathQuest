using mathquest;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Net;
using System.Transactions;

namespace mathquest
{

    public class Operations() {

        static void Main(string[] args){
            //ARRAY
            //int[] idades = { 20, 10, 55, 12, 34 };

            //Console.WriteLine("Total de registros: " + idades.Length);
            //Console.WriteLine(Array.IndexOf(idades, 55)); //pega o indice do elemento 
            //Array.Sort(idades); //organiza os itens da lista
            //Array.Reverse(idades);

            //foreach(int i in idades)
            //{
            //Console.WriteLine(i);
            //}


            //LIST
            //List<int> notas = new List<int> { 9, 4, 5, 10 };
            //notas.Add(7);
            //notas.Remove(9);
            //notas.Insert(2, 6);//indice, valor
            //notas.RemoveAt(2);

            //foreach (int i in notas)
            //{
            //    Console.WriteLine(i);
            //}


            //IF ELSE
            //int num1 = 20;
            //int num2 = 20;

            //if (num1 > num2)
            //{
            //    Console.WriteLine("O numero 1 é maior");
            //}
            //else if (num1 < num2)
            //{
            //    Console.WriteLine("O numero 2 é maior");
            //}
            //else
            //{
            //    Console.WriteLine("Os números são iguais");
            //}

            bool foiPromovido = true;
            double salario = 1200.0;

            if (!foiPromovido)
            {
                salario = 5000.0;
            }
            else
            {
                salario = 1200.0;
            }
            Console.WriteLine(salario);


            //SWICH CASE
            //string grau = "";
            //Console.WriteLine("Informe o grau obtido: ");
            //grau = Console.ReadLine();

            //switch (grau)
            //{
            //    case "A":
            //        Console.WriteLine("Grau A");
            //        break;
            //    case "B":
            //        Console.WriteLine("Grau B");
            //        break;
            //    case "C":
            //        Console.WriteLine("Grau C");
            //        break;
            //}


        }

    }

}



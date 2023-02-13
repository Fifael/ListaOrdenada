/*Insertion Sort*/
using System;
using System.IO;
using System.Collections.Generic;

namespace ProvaCsharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            string arquivo = "Forget.txt";
            int contador = 0;

            StreamReader Leitor = new StreamReader(arquivo); 
            while (!Leitor.EndOfStream)
            {
                Leitor.ReadLine();
                contador++;
            }

            string[] ArquivoNormal = new string[contador];
            int[] ListaConvertida = new int[contador];

            try
            {
                StreamReader RecebedorDois = new StreamReader(arquivo); 
                int i = 0;
                while (!RecebedorDois.EndOfStream)
                {
                    ArquivoNormal[i] = RecebedorDois.ReadLine();
                    i++;
                }
                RecebedorDois.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Por favor crie um arquivo de texto");
            }

            for (int i = 0; i < contador; i++)
            {
                ListaConvertida[i] = int.Parse(ArquivoNormal[i]);
            }
            for (int j = 0; j < contador; j++)
            {
                int chave = ListaConvertida[j];

                int i = j - 1;

                

                while (i > -1 && ListaConvertida[i] > chave)
                {
                    ListaConvertida[i + 1] = ListaConvertida[i];
                    i--;
                }
                ListaConvertida[i + 1] = chave;
                Console.WriteLine("Ordenando: " + string.Join(",", ListaConvertida));            
            }
            

            Console.WriteLine("\n" + "Ordenado: " + string.Join(",", ListaConvertida));

            using (StreamWriter ForgetOrdenado = new StreamWriter("Ordenado.txt"))
            {
                ForgetOrdenado.WriteLine("Array ordenada: " + string.Join(", ", ListaConvertida));
            }
        }
    }
}
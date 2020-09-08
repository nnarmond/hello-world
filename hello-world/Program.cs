using System;
using System.Collections.Generic;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] pessoas = new String[3];
            pessoas[0] = "Nathalia";
            pessoas[1] = "João";
            pessoas[2] = "Mateus";

            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine("Hello " + pessoas[i] + " !");
            }

            var frutas = new List<String>();
            frutas.Add("banana");
            frutas.Add("maçã");
            frutas.Add("morango");

            frutas.ForEach((String fruta) =>
            {
                Console.WriteLine("Gosto de " + fruta + " !");
            });

            while (frutas.Count < 3)
            {
                frutas.Add("pêssego");
            }

            frutas.ForEach((String fruta) =>
            {
                Console.WriteLine("Gosto de " + fruta + " !");
            });

            do
            {
                frutas.Add("pêssego");
            } while (frutas.Count < 3);

            frutas.ForEach((String fruta) =>
            {
                Console.WriteLine("Gosto de " + fruta + " !");
            });
        }
    }
}

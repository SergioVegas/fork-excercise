using System;
namespace RefactorFork
{
    public class Program
    {
        public static void Main()
        {
            //Constantes
            const string TextOne = "Escull la quantitat de nombres  que vols introduïr, han d'estar en el rang  15 a 100: ";//Missatge poc clar i escrit malament.
            const string ForEachNumber = "Introdueix el seguent número, {0}: ";
            //const string LineBreaker = "\n"; No es necesaria una constant per fer un salt de linea, es pot fer un ConsoleWriteLine en compes d'un Console.Write
            const string Product = "El producte de cada un dels números es: ";

            //La variable pot ser declarada directametn al demanar el numero per consola i no fa falta retornar el que acaben de ficar.
        
            Console.WriteLine(TextOne);

            int numInputs = Convert.ToInt32(Console.ReadLine());
                 

            int[] numsToCatch = new int[numInputs];

            // recompte de numeros introduits per l'usuari
            for (int i = 0; i < numInputs; i++)
            {
                string putTheNums = string.Format(ForEachNumber, i + 1);
                Console.WriteLine(putTheNums);//Canvi de Write a WriteLine
                numsToCatch[i] = Convert.ToInt32(Console.ReadLine());
            }
          
            int productAllNumbers = 0;
            for (int i = 0; i < numInputs; i++)
            {
                productAllNumbers /= numsToCatch[i];
            }

            Console.WriteLine(Product + productAllNumbers);
        }
    }
}

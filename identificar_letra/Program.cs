using System;
using System.Text;

namespace identificar_letra
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "";
            do {
                string a, b = "";
                int Cantidad_caracteres = 0;
                
                int cont1 = 0, cont2 = 0;
                Console.WriteLine("Ingrese una frase");
                a = Console.ReadLine();
                Console.WriteLine("Ingrese Cantidad de Caracteres:");
                Cantidad_caracteres = int.Parse(Console.ReadLine());
                if (a.Length>=100)
                {
                    Console.WriteLine("Error debe tener menos de 100 Carateres");
                }
                else
                {
                    string str = new StringBuilder(a.Length * 4).Insert(0, a, 4).ToString();

          

                    StringBuilder builder = new StringBuilder(str, 10);
                    builder.Length = Cantidad_caracteres;
                    builder.Capacity = 1000000;

                    for (int i = 0; i < builder.Length; i++)
                    {
                        b = builder.ToString().Substring(i,1);
                        if (b=="a")
                        {
                            cont2++;
                        }
                        cont1++;

                    }
                    Console.WriteLine("Tendriamos la siguiente Frase:" + "" + builder);
                    Console.WriteLine("");
                    Console.WriteLine("La letra A se repite" + " " + cont2 + " " + "veces");
                    Console.WriteLine("Cantidad de letra son: " + cont1);
                    Console.WriteLine("Desea Continuar s/n");
                    continuar = Console.ReadLine();
                    
                    Console.ReadKey();
                }
            } while (continuar == "s" || continuar == "S");

        }

             
    }
}

using System;

namespace piedra_papel__y_tijera
{
    internal class Program
    {
        public static void Main()
        {
            int puntosMaquina = 0;
            int puntosHumano = 0;

            Random rnd = new Random();

            Console.WriteLine("Jugar piedra, papel o tijera maquina vs hombre");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese 0 para piedra");
                Console.WriteLine("Ingrese 1 para papel");
                Console.WriteLine("Ingrese 2 para tijera");
                Console.Write(">"); // puro diseño
                int humano = int.Parse(Console.ReadLine());
                int maquina = rnd.Next(0, 3);

                if (humano == 0 && maquina == 2)
                {
                    puntosHumano++;
                }
                else
                {
                    if (humano == 2 && maquina == 0)
                    {
                        puntosMaquina++;
                    }
                }

                if (humano == 1 && maquina == 0)
                {
                    puntosHumano++;
                }
                else
                {
                    if (humano == 0 && maquina == 1)
                    {
                        puntosMaquina++;
                    }
                }

                if (humano == 2 && maquina == 1)
                {
                    puntosHumano++;
                }
                else
                {
                    if (humano == 1 && maquina == 2)
                    {
                        puntosMaquina++;
                    }
                }



            }

            if (puntosHumano == puntosMaquina)
            {
                Console.WriteLine("Empate");
            }
            else if (puntosHumano > puntosMaquina)
            {
                Console.WriteLine("Gano Humano");
            }
            else
            {
                Console.WriteLine("Gano Maquina");
            }
            
        }
    }
}
﻿public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("prueba2");

        //variables de entrada
        int Njugadores;
        bool jugarNuevamente = true;
        bool adivinanza = false;
        int turno = 0;  

        // se pide cantidad de jugadores
        while (jugarNuevamente)
        {
            Njugadores = 0;
            while (Njugadores >= 2 || Njugadores <= 4)
            {
                Console.Write("Cantidad de jugares, minimo 2 y maximo 4: ");
                Njugadores = int.Parse(Console.ReadLine());
            }
            // Determinar el rango de números aleatorios
            Random random = new Random();
            int numeroAleatorio = 0;
            if (Njugadores == 2)
            {
                numeroAleatorio = random.Next(0, 51); // Generar un número entre 0 y 50
            }
            else if (Njugadores == 3)
            {
                numeroAleatorio = random.Next(0, 101); // Generar un número entre 0 y 100
            }
            else if (Njugadores == 4)
            {
                numeroAleatorio = random.Next(0, 201); // Generar un número entre 0 y 200
            }

            //ciclo de la adivinanza
            while (!adivinanza)
            {
                // jugador con el turno
                int jugadorActual = (turno % Njugadores) + 1;

                Console.WriteLine($"\nTurno del Jugador {jugadorActual}");
                Console.Write("Ingresa un número: ");
                int intento = int.Parse(Console.ReadLine());



            }
    }
}
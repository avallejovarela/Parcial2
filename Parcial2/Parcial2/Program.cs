public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("prueba2");

        //variables de entrada
        int Njugadores;
        bool jugarNuevamente = true;

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

        }
    }
}
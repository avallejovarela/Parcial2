public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sistema de evaluación de notas de estudiantes");
        // variables de entrada
        bool continuar = true;
        int numeroEstudiantes;
        string nombre;
        int cantidadNotas;
        double sumaNotas, nota, promedio;
        while (continuar) 
        {
            Console.WriteLine("Ingresa la cantidad de estudiantes; ");
            numeroEstudiantes = int.Parse(Console.ReadLine());

            int ganaron = 0, perdieron = 0;

            for (int i = 0; i < numeroEstudiantes; i++)
            {
                Console.WriteLine($"Ingrese el nombre del estudiante {i + 1}:");
                nombre = Console.ReadLine();

                Console.WriteLine($"Ingrese la cantidad de notas del estudiante {nombre}:");
                cantidadNotas = int.Parse(Console.ReadLine());

                sumaNotas = 0;
                for (int j = 0; j < cantidadNotas; j++) ;
                {
                    Console.WriteLine($"Ingrese la nota {j + 1} del estudiante {nombre}:");
                    nota = double.Parse(Console.ReadLine());
                    sumaNotas += nota;
                }
                 promedio = sumaNotas / cantidadNotas;
            }
        }
}
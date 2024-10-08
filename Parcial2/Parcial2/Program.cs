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
            Console.Clear();
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
                for (int j = 0; j < cantidadNotas; j++)
                {
                    Console.WriteLine($"Ingrese la nota {j + 1} del estudiante {nombre}:");
                    nota = double.Parse(Console.ReadLine());
                    sumaNotas += nota;
                }
                promedio = sumaNotas / cantidadNotas;

                // Clasificar estudiante
                string categoria;
                if (promedio >= 4.5)
                {
                    categoria = "Excelente";
                }
                else if (promedio >= 4.0 && promedio <= 4.4)
                {
                    categoria = "Sobresaliente";
                }
                else if (promedio >= 3.5 && promedio <= 3.9)
                {
                    categoria = "Bueno";
                }
                else
                {
                    categoria = "Insuficiente";
                }
                //  resultados de cada estudiante
                Console.WriteLine($"Estudiante: {nombre}, Promedio: {promedio:F2}, Categoría: {categoria}");

                // Contar ganadores y perdedores
                if (promedio >= 3.5)
                {
                    ganaron++;
                }
                else
                {
                    perdieron++;
                }
            }
            //  resumen final
            Console.WriteLine($"\nTotal de estudiantes que ganaron: {ganaron}");
            Console.WriteLine($"Total de estudiantes que perdieron: {perdieron}");

            // Preguntar si desea continuar
            Console.WriteLine("\n¿Desea ingresar otro grupo de estudiantes? (s/n):");
            string respuesta = Console.ReadLine().ToLower();
            continuar = respuesta == "s";
        }
    }
}
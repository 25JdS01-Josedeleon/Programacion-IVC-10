internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("====Promedio de calificaciones====");
        string materia;
        int n1, n2, n3, n4, n5;
        double promedio;
        Console.WriteLine("Ingrese el nombre de la materia: ");
        materia = Console.ReadLine();
        Console.WriteLine("dame 5 notas: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());
        n4 = Convert.ToInt32(Console.ReadLine());
        n5 = Convert.ToInt32(Console.ReadLine());

        promedio = (n1 + n2 + n3 + n4 + n5) / 5;

        if (promedio >= 70)
            Console.WriteLine("El promedio es: "+promedio+ " y el estudiante aprobo");
        else
            Console.WriteLine("El promedio es: "+promedio+" y el estudiante resaprobo");
        {

        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==BUZON DE VOZ==");
        int num;
        Console.WriteLine("Digite un número según las opciones");
        Console.WriteLine("1 VENTAS");
        Console.WriteLine("2 RECEPCIÓN");
        Console.WriteLine("3 DIRECCIÓN");
        Console.WriteLine("4 COMPRAS");
        num = Convert.ToInt32(Console.ReadLine());
        if (num == 1)
        {
            Console.WriteLine("Bienvenido al departamento de ventas");
            Console.WriteLine("Responsable: Juan David Avila Ortiz");
            Console.WriteLine("Correo: j.avila@gmail.com");
        }
        else if (num == 2)
        {
            Console.WriteLine("Bienvenido al departamento de Recepción");
            Console.WriteLine("Responsable: Jose Martin Miranda Lopez");
            Console.WriteLine("Correo: j.miranda@gmail.com");
        }
        else if (num == 3)
        {
            Console.WriteLine("Bienvenido al departamento de Dirección");
            Console.WriteLine("Responsable: Diego Samuel Veliz Osorio");
            Console.WriteLine("Correo: d.veliz@gmail.com");
        }
        else if (num == 4)
        {
            Console.WriteLine("Bienvenido al departamento de Compras");
            Console.WriteLine("Responsable: Andres Zamudio Esquivel");
            Console.WriteLine("Correo: a.zamudio@gmail.com");
        }
        else
            Console.WriteLine("NUMERO INVALIDO");
    }
}
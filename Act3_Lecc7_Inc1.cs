internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==estaciones del año==");
        int dia, mes;
        Console.WriteLine("dime el numero del dia");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("dime el numero del mes");
        mes = Convert.ToInt32(Console.ReadLine());
        if (dia >= 20 & dia <= 31 & mes >= 3 || dia >= 1 & dia <= 30 & mes == 4 || dia >= 1 & dia <= 31 & mes <= 5 || dia >= 1 & dia <= 20 & mes == 6)
            Console.WriteLine("Primavera");
        else if (dia >= 21 & dia <= 30 & mes == 6 || dia >= 1 & dia <= 31 & mes == 7 || dia >= 1 & dia <= 31 & mes == 8 || dia >= 1 & dia <= 23 & mes == 9)
            Console.WriteLine("Verano");
        else if (dia >= 24 & dia <= 30 & mes == 9 || dia >= 1 & dia < 31 & mes == 10 || dia >= 1 & dia <= 30 && mes == 11 || dia >= 1 & dia <= 21 & mes == 12)
            Console.WriteLine("otoño");
        else if (dia >= 22 & dia <= 30 & mes == 12 || dia >= 1 & dia >= 1 & dia <= 31 & mes == 1 || dia >= 1 & dia <= 29 & mes == 2 || dia >= 1 & dia <= 20 & mes == 3)
            Console.WriteLine("Invierno");
        else
            Console.WriteLine("fecha invalida");
    }
}
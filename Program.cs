using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string texto = "Este es mi correo electrónico: juan_perez.23@gmail.com. Por favor, envíeme un correo con sus comentarios.";

        string patron = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";

        MatchCollection coincidencias = Regex.Matches(texto, patron);

        Console.WriteLine("Direcciones de correo electrónico encontradas:");
        foreach (Match match in coincidencias)
        {
            Console.WriteLine(match.Value);
        }
    }
}


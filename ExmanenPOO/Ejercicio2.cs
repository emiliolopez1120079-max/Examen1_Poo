using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace ExmanenPOO
{
    public class Ejercicio2
    {
        public Ejercicio2()
        {
            string Categoria;
            decimal saldo = 5000.00m;
            String texto;
            if(saldo<1000)
            {
             Categoria = "Basico";
             texto = "Abra un CDT para mejorar su categoría.";
            }
            else if(saldo<5000)
            {
             Categoria = "Plata";
             texto = "Tiene acceso a tarjeta de débito sin comisión.";
            }
            else if(saldo<20000)
            {
             Categoria = "Oro";
             texto = "¡Felicidades! Accede a tasas preferenciales.";
            }
            else
            {
             Categoria = "Platino";
             texto = "¡Cliente VIP! Accede a todos los beneficios del banco.";
            }
Console.WriteLine("\nTabla de Control");
Console.WriteLine($"Saldo actual:\t{saldo:F2}");
Console.WriteLine($"Categoria:\t{Categoria}");
Console.WriteLine($"{texto}");
        }
    }
}
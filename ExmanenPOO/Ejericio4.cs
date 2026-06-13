using System.Dynamic;

namespace ExmanenPOO
{
        public class Productos
    {
           public string Nombre { get; set;}
           public decimal Precio {get;set;}
           public  int Stock {get;set;}
            public string ObtenerInfo(string nombre, decimal precio, string stock)
           {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            return ($"{nombre} — Precio: L. {precio} — Stock: {Stock} unidades");
           }
           int ClacularInventario(decimal precio, int stock)
           {
             
           }
        //    public Inventario(string nombre, decimal Precio, string stock)
        //   { 
             
        //   }
    }
}
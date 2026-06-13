namespace ExmanenPOO
{
    public class Ejercicio1
    {
        public Ejercicio1()
        {
            string nombreProducto = "Fertilizante NPK";
            double precioPorKg = 35.75;
            int cantidadKg = 12;
            int descuentoPorcentaje = 10;

            double subtotal = precioPorKg * cantidadKg;
            double descuento = subtotal * descuentoPorcentaje / 100;
            double totalFinal = subtotal - descuento;

            Console.WriteLine($"=== FACTURA AGROCOPRÁN ===");
            Console.WriteLine($"Producto:\t{nombreProducto}");
            Console.WriteLine($"Cantidad:\t{cantidadKg}");
            Console.WriteLine($"Precio/Kg:\tLps {precioPorKg:F2}");
            Console.WriteLine($"Subtotal:\tLps {subtotal:F2}");
            Console.WriteLine($"Descuento:\tLps {descuento:F2}");
            Console.WriteLine($"Total:\t\tLps {totalFinal:F2}");
        }
    }
}
namespace ExmanenPOO
{
    public class Ejercicio3
    {
        public Ejercicio3()
        {
            Console.WriteLine("Ingrese el numero cuya tabla desea ver");
            int.TryParse(Console.ReadLine(), out int tabla);
            if(tabla<1)
            {
                Console.WriteLine("El numero ingresado no es valido");
            }
            else
            {
            Console.WriteLine("Ingrese el limite de la tabla");
            int.TryParse(Console.ReadLine(), out int limite);
            if(limite<1)
            {
                Console.WriteLine("El numero ingresado no es valido");
            }
            else
                {
                    Console.WriteLine($"Tabla del {tabla}\n==========================");
                    for(int i=1;i<=limite;i++)
                    {
                        Console.WriteLine($"{tabla} x {i}\t= {tabla*i}");
                    }
                }
            }
        }
    }
}
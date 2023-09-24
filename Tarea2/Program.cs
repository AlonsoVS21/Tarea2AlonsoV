using System;

namespace TiendaDeCamisas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la tienda de camisas");

            // Solicitar la cantidad de camisas y el precio por camisa al usuario
            Console.Write("Ingrese la cantidad de camisas que desea comprar: ");
            int cantidadCamisas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio por camisa: ");
            double precioPorCamisa = double.Parse(Console.ReadLine());

            // Calcular el precio total sin descuento
            double precioTotalSinDescuento = cantidadCamisas * precioPorCamisa;

            // Calcular el descuento
            double descuento = 0.0;
            if (cantidadCamisas >= 2 && cantidadCamisas <= 5)
            {
                // Descuento del 15% para 2-5 camisas
                descuento = precioTotalSinDescuento * 0.15;
            }
            else if (cantidadCamisas > 5)
            {
                // Descuento del 20% para más de 5 camisas
                descuento = precioTotalSinDescuento * 0.20;
            }

            // Calcular el precio total con descuento
            double precioTotalConDescuento = precioTotalSinDescuento - descuento;

            // Mostrar el resultado
            Console.WriteLine("Cantidad de camisas: " + cantidadCamisas);
            Console.WriteLine("Precio por camisa: $" + precioPorCamisa);
            Console.WriteLine("Precio total sin descuento: $" + precioTotalSinDescuento);
            Console.WriteLine("Descuento aplicado: $" + descuento);
            Console.WriteLine("Precio total con descuento: $" + precioTotalConDescuento);

            // Mantener la consola abierta hasta que el usuario presione una tecla
            Console.ReadKey();
        }
    }
}

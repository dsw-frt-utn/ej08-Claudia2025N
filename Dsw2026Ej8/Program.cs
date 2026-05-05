namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos la clase
            //ProductHelper helper = new ProductHelper();

            // Llamamos al método que creaste y guardamos el resultado
            //string etiqueta = helper.ObtenerEtiquetaProducto(101, "Teclado Mecánico", 45000m);

            // Imprimimos el resultado en la consola para ver si funciona el formato
            //Console.WriteLine(etiqueta);
            //Product productPrueba= new Product("Teclado Mecánico");
            //Console.WriteLine(new Problema3().CompararCopias(10, productPrueba));

            //Console.WriteLine(new Problema4().CalcularPromedio(8, null, 9)); // Debería imprimir 8.5


            Problema5 problema5 = new Problema5();

            // Probamos con la hija Retail (sin descuento)
            RetailSale ventaNormal = new RetailSale { ImporteBase = 1000m };
            Console.WriteLine("------------------Problema 5---------------");
            Console.WriteLine("................VENTA MINORISTA...............");
            Console.WriteLine($"Importe Base:{ ventaNormal.ImporteBase }"); // Va a imprimir 1000
            Console.WriteLine($"Importe de Venta por Menor:{problema5.ObtenerImporteFinal(ventaNormal)}"); // Va a imprimir 1000

            //Probamos con la hija Wholesale (con 10% de descuento)
            Console.WriteLine("................VENTA MAYORISTA...............");
            WholesaleSale ventaMayorista = new WholesaleSale { ImporteBase = 100000m };
            Console.WriteLine($"Importe Base:{ventaMayorista.ImporteBase}"); // Va a imprimir 100000
            Console.WriteLine($"Importe de Venta por Mayor:{problema5.ObtenerImporteFinal(ventaMayorista)}"); // Va a imprimir 90000


            //Problema 6
            //Problema6 problema6 = new Problema6();
            //Console.WriteLine(problema6.NormalizarCodigoProducto("ab 123 x ")); // Debería imprimir "AB-123-X"

        }
    }
}

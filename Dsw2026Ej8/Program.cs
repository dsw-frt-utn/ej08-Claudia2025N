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


            //Problema5 problema5 = new Problema5();

            // Probamos con la hija Retail (sin descuento)
            //RetailSale ventaNormal = new RetailSale { ImporteBase = 1000m };
            //Console.WriteLine(problema5.ObtenerImporteFinal(ventaNormal)); // Va a imprimir 1000

            // Probamos con la hija Wholesale (con 10% de descuento)
            //WholesaleSale ventaMayorista = new WholesaleSale { ImporteBase = 1000m };
            //Console.WriteLine(problema5.ObtenerImporteFinal(ventaMayorista)); // Va a imprimir 900
        }
    }
}

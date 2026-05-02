using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            string precioFormateado = price.ToString("C");
            return string.Format(FormatoEtiqueta, code, description, precioFormateado);
        }
    }
}

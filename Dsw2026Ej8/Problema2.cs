using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
         
            decimal totalVenta = 0;
            if (quantity > 0)
            {
                totalVenta = quantity * unitPrice;
            }

            //clase anonima
            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = totalVenta
            };

            
            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
        }
    }
}

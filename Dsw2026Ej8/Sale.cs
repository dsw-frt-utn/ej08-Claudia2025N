using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        
        public decimal ImporteBase { get; set; }

        // Método virtual 
        public virtual decimal CalculateTotal()
        {
            return ImporteBase;
        }
    }

    
    public class RetailSale : Sale 
    {
       
        public override decimal CalculateTotal()
        {
            return ImporteBase;
        }
    }

    public class WholesaleSale : Sale 
    {
        // Redefinimos el método, aplicamos un 10% de descuento
        public override decimal CalculateTotal()
        {
            // Multiplicar por 0.90m es lo mismo que restar el 10%
            return ImporteBase * 0.90m;
        }
    }

 
   
}

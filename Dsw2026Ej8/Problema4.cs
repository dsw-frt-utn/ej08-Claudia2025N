using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
    { 
        double suma = 0;
        int cantidadNotasValidas = 0;

        // .HasValue verifica si la variable no es null de forma segura, evitando excepciones
        //.Value accede al valor real de la variable nullable, pero solo si HasValue es true, por eso se evalúan juntos
        //.HasValue es true si la variable tiene un valor asignado (no es null)
        if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10) 
        {
            suma += nota1.Value;
            cantidadNotasValidas++;
        }
        if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10) 
        {
            suma += nota2.Value;
            cantidadNotasValidas++;
        }

        if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
        {
            suma += nota3.Value;
            cantidadNotasValidas++;
        }

        
        if (cantidadNotasValidas == 0)
        {
            return 0; 
        }

        
        return suma / cantidadNotasValidas;
    }
}
}

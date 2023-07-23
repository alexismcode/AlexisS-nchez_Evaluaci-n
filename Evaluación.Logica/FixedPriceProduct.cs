using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programa realizado por Alexis Sánchez
namespace Evaluación.Logica
{
    public class FixedPriceProduct : Product
    {

        public override decimal ValueToPay()
        {
            return Price + (Price * (decimal)Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Price......: {Price,20:C2}\n\t" +
                   $"Tax........: {Tax,20:P2}\n\t" +
                   $"Value......: {ValueToPay(),20:C2}";
        }
    }
}
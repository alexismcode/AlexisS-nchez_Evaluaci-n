using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programa realizado por Alexis Sánchez
namespace Evaluación.Logica
{
    public class VariablePriceProduct : Product
    {
        private string? _measurement;
        private float _quantity;

        public string? Measurement
        {
            get => _measurement;
            set => _measurement = value;
        }
        public float Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }
        public override decimal ValueToPay()
        {
            return Price * (decimal)Quantity + (Price * (decimal)Quantity * (decimal)Tax);
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Measurement: {Measurement}\n\t" +
                   $"Quantity...: {Quantity,20:N2}\n\t" +
                   $"Price......: {Price,20:C2}\n\t" +
                   $"Tax........: {Tax,20:P2}\n\t" +
                   $"Value......: {ValueToPay(),20:C2}";
        }

       
    }
}
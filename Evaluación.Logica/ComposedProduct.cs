using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programa realizado por Alexis Sánchez
namespace Evaluación.Logica
{
    public class ComposedProduct : Product
    {
        private float _discount;

        public float Discount
        {
            get => _discount;
            set => _discount = value;
        }

        public List<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal totalValue = 0;
            foreach (var product in Products)
            {
                totalValue += product.ValueToPay();
            }
            return totalValue - (totalValue * (decimal)Discount);
        }


        public override string ToString()
        {
            string productList = string.Join(", ", Products.Select(p => p.Description));
            return $"{Id} {Description}\n\t" +
                   $"Products...: {productList}\n\t" +
                   $"Discount...: {Discount,20:P2}\n\t" +
                   $"Value......: {ValueToPay(),20:C2}"; ;

        }
    }
}
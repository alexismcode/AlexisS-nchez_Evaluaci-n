using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programa realizado por Alexis Sánchez
namespace Evaluación.Logica
{
    public class Invoice : iPay
    {
        private List<Product> _products;

        public Invoice()
        {
            _products = new List<Product>();
        }


        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal ValueToPay()
        {
            decimal totalValue = 0;
            foreach (var product in _products)
            {
                totalValue += product.ValueToPay();
            }
            return totalValue;
        }
        public override string ToString()
        {
            string receipt = "RECEIPT\n";
            receipt += "-------------------------------------------------\n";

            foreach (var product in _products)
            {
                receipt += product.ToString() + "\n";
            }
            receipt += "                          =============\n";
            receipt += $"TOTAL: {ValueToPay(),34:C2}\n";
            return receipt;
        }
    }
}

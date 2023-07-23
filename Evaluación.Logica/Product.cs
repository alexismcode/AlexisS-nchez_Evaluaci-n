
// Programa realizado por Alexis Sánchez
namespace Evaluación.Logica
{
    public abstract class Product : iPay
    {
        public string? Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{Description}\n\t";
        }

        public abstract decimal ValueToPay();
    }
}
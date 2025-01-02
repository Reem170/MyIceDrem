using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace MyIceDream.Models
{
    public class Order
    {
        public int OrderId { get; set;}
        public int TotalPrice { get; set; }

        public DateTime Time { get; set; }
        public int Amount { get; set; }
        public List<Product> Products { get; set; }
        public int UserId { get; set; }

    }
}

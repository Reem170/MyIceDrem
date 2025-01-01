namespace MyIceDream.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public byte[] ImageData { get; set; } // Store image as binary data
       
    }
}

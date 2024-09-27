namespace e_commerce.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;

        public string CustomerEmail { get; set; } = string.Empty;

        public string CustomerPhone { get; set; } = string.Empty;

        public string CustomerCity { get; set; } = string.Empty;

        public string CustomerAddress { get; set; } = string.Empty;


    }
}

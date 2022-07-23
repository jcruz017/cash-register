namespace CashRegister.Models
{

    public class Product
    {
        public int ProductId { get; set; }


        public string Name { get; set; } = string.Empty;

        public int Saleprice { get; set; }


        public int Buyprice { get; set; }

        public int Quantity { get; set; }

        public bool IsActive { get; set; }
    }
    
}
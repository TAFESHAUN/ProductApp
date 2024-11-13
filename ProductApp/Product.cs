namespace ProductApp
{
    /// <summary>
    /// Product class type for Product object list from CSV data
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCalcCode { get; set; }
    }

}

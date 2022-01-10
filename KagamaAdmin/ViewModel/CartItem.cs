namespace KagamaAdmin.ViewModel
{
    public class CartItem
    {
        public int IdProduct { get; set; }
        public string Img { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public string VendorCode { get; set; }
        public int Count { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceKit { get; set; }
        public decimal? TotalSum { get; set; }
        public bool Stock { get; set; }
    }
}

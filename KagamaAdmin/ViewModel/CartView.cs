using System.Collections.Generic;
using System.Linq;

namespace KagamaAdmin.ViewModel
{
    public class CartView
    {
        public uint IdCart { get; set; }
        public List<CartItem> Items { get; set; }
        public int CountProducts
        {
            get { return Items.Count(); }
        }
        public decimal? TotalSumProducts
        {
            get { return Items.Sum(x => x.TotalSum); }
        }
        public CartView()
        {
            Items = new List<CartItem>();
        }

        public CartItem this[int idProduct]
        {
            get { return this.Items.SingleOrDefault(x => x.IdProduct == idProduct); }
        }
    }
}

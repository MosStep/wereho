using System.Collections.Generic;

namespace WarehouseWMS.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public ICollection<InventoryTransaction> Transactions { get; set; }
    }
}
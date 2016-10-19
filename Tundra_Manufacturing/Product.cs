using System;

namespace Tundra_Manufacturing
{
    public class Product
    {
        public string ProductDescription { get; set; }
        public string InventoryCode { get; set; }
        public DateTime? DateAvailable { get; set; }
        public decimal? CostPerUnit { get; set; }
        public int? Quantity { get; set; }
        public string Comments { get; set; }
    }
}

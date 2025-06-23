namespace TechHaven.Models
{
    public class Suppliers
    {
        public int SuppliersID { get; set; }
        public int ProdcutsId { get; set; }
        public string SupplierName { get; set; }
        public int SupplierContact { get; set; }
        public string SupplierProduct { get; set; }
        public int DeliveryTime { get; set; }

        public Products Products { get; set; }

    }


}      
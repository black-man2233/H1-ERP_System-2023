namespace H1_ERP_System_2023.Domain_Model
{
    internal class Customer : Person
    {
        public int customerNumber { get; set; }
        public DateTime LastPurchaseDate { get; set; }
    }
}

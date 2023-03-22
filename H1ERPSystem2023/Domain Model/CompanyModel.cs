namespace H1ERPSystem2023.DomainModel
{
    internal class CompanyModel
    {
        public string ItemNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int salgspris { get; set; }
        public string Location { get; set; } // nummer på 4 bogstaver, 
        public int Quantity { get; set; }
        public string Measure { get; set; }
    }
}

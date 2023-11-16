namespace Standing_Order_Vat_App.DAL.CoreData_DB
{
    public partial class Customer
    {
        public string? AcctName { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public int? Cif { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public double? Zip { get; set; }
        public string? PhoneNum1 { get; set; }
        public string? PhoneNum2 { get; set; }
        public int CustId { get; set; }
    }
}

namespace BIT.Joseph.Udoka.Models
{
    public class User
    {
        public int id { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string Email { set; get; }
    }

    public class Payments
    {
        public int userID { set; get; }
        public int payerID { set; get; }
        public decimal Amount { set; get; }
    }
}

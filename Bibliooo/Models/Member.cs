namespace Bibliooo.Models
{
    public class Member
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone_num { get; set; }
        public List<Loan> loans { get; set; }
    }
}

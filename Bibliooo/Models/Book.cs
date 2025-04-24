namespace Bibliooo.Models
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public List<Genre> genres { get; set; }
        public List<Publisher> publishers { get; }
        public List<Loan> loans { get; set; }
    }
}

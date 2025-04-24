namespace Bibliooo.Models
{
    public class Publisher
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Book> books { get; set; }
    }
}

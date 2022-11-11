namespace Programmer.Models
{
    public class Status
    {
        public int StatusID { get; set; }
        public string Status_name { get; set; }
        public ICollection<Developer> Developer { get; set; }
    }
}

namespace Programmer.Models
{
    public class Developer
    {
        public int DeveloperID { get; set; }
        public string Developer_name { get; set; }
        public string E_mail { get; set; }
        public string Job { get; set; }


        public int StatusID { get; set; }
        public Status Status { get; set; }
        public int SkillID { get; set; }
        public Skill Skill { get; set; }
        public ICollection<Quiz> Quiz { get; set; }
    }
}

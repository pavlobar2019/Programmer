namespace Programmer.Models
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string Skill_name { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string Question4 { get; set; }
        public string Question5 { get; set; }

        public ICollection<Developer> Developer { get; set; }
    }
}

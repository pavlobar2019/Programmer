namespace Programmer.Models
{
    public class Quiz
    {
        public int QuizID { get; set; }

        public DateTime Date_quiz { get; set; }

        public int DeveloperID { get; set; }
        public Developer Developer { get; set; }
    }
}

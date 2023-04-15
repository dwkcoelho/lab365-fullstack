namespace quiz.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public int Discipline_Id { get; set; }
        public string Title { get; set; }
        public DateTime Date_Open { get; set; }
        public DateTime Date_Close { get; set; }

        public virtual Discipline Discipline { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}

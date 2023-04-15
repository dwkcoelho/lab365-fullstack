namespace quiz.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public int Teacher_Id { get; set; }
        public string Name_Discipline { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student_Discipline> Student_Disciplines { get; set; }
        public virtual ICollection<Quiz> Quizzes { get; set; }
    }
}

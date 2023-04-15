namespace quiz.Models
{
    public class Student_Discipline
    {
        public int Id { get; set; }
        public int Student_Id { get; set; }
        public int Discipline_Id { get; set; }

        public virtual Student Student { get; set; }
        public virtual Discipline Discipline { get; set; }
    }
}

namespace quiz.Models
{
    public class Student : User
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Period { get; set; }
        public int Ra { get; set; } 

        public virtual User User { get; set; }
        public virtual ICollection<Student_Discipline> Disciplines { get; set; }
    }
}

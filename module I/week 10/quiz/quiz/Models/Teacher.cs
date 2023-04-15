namespace quiz.Models
{
    public class Teacher : User
    {
        public int User_Id { get; set; }
        public string Department { get; set; } 
        public virtual User User { get; set; }
    }
}

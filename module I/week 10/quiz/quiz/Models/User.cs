namespace quiz.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Cpf { get; set; }
        public string Password { get; set; }   

        public virtual ICollection<Student> Students { get; set;}
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}

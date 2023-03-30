namespace school.Models
{
    public class SubjectGrade
    {
        public int Id { get; set; }
        public decimal Grade { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}

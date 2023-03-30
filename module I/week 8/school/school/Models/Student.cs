namespace school.Models
{
    public class Student : Person
    {
        public List<SubjectGrade> Grades { get; set; }
    }
}

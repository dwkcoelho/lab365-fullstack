using Microsoft.Extensions.Diagnostics.HealthChecks;
using school.Dtos;
using school.Models;

namespace school.Repositories
{
    public class StudentRepository
    {
        public static List<Student> studentList = new List<Student>()
        {
            new Student() { Id = 1, Name = "Gabriel"},
            new Student() { Id = 2, Name = "Rafael"},
            new Student() { Id = 3, Name = "Maria"},
            new Student() { Id = 4, Name = "Julia"}
        };
        public List<Student> ShowStudents(string student)
        {
            if (string.IsNullOrEmpty(student))
            {
                return studentList;
            }
            else
            {
                return studentList.Where(x => x.Name.ToLower().Contains(student.ToLower()))
                    .OrderBy(x => x.Id).ToList();
            }
        }
        public Student GetStudent(int id)
        {
            return studentList.FirstOrDefault(x => x.Id == id);
        }
        public Student AddStudent(StudentDto dto)
        {
            var student = new Student();
            student.Id = CreateId();
            student.Name = dto.Name;

            studentList.Add(student);
            return student;
        }
        private int CreateId()
        {
            return studentList.Last().Id + 1;
        }
        public void DeleteStudent(int id)
        {
            var student = studentList.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                studentList.Remove(student);
            }

        }
    }
}

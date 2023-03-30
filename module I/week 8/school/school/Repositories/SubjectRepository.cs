
using System.Globalization;
using System.Text;
using school.Dtos;
using school.Models;
using static school.Controllers.SubjectController;

namespace school.Repositories
{
    public class SubjectRepository
    {
        public static List<Subject> subjectList = new List<Subject>()
        {
            new Subject() {Id = 1, Name = "History", Workload = 20 },
            new Subject() {Id = 2, Name = "English", Workload = 20 },
            new Subject() {Id = 3, Name = "Science", Workload = 50 },
            new Subject() {Id = 4, Name = "Mathematics", Workload = 60 }
        };
        public List<Subject> ShowSubjects(string subject)
        {
            if (string.IsNullOrEmpty(subject))
            {
                return subjectList;
            }
            else
            {
                return subjectList.Where(x => x.Name.ToLower().Contains(subject.ToLower()))
                    .OrderBy(x => x.Id).ToList(); 
             
            }
        }
        public Subject GetSubject(int id)
        {
            return subjectList.FirstOrDefault(x => x.Id == id);
        }
        
        public Subject AlterSubject(int id, SubjectDto dto)
        {
            var subject = GetSubject(id);
            subjectList.Remove(subject);

            subject.Workload = dto.Workload;
            subject.Name = dto.Name;
            subject.ChangeDate = DateTime.Now;

            subjectList.Add(subject);

            return subject;
        }
        public Subject AddSubject(SubjectDto dto)
        {
            var subject = new Subject();
            subject.Id = CreateId();
            subject.Workload = dto.Workload;
            subject.Name = dto.Name;
            subject.ChangeDate = DateTime.Now;

            subjectList.Add(subject);

            return subject;
        }
        public void DeleteSubject(int id)
        {
            var subject = subjectList.FirstOrDefault(x => x.Id == id);
            if (subject != null)
            {
                subjectList.Remove(subject);
            }
            
        }
        private int CreateId()
        {
            return subjectList.Last().Id + 1;
        }
    }
}
public static class StringExtension
{
    public static string RemoveAccent(this string text)
    {
        StringBuilder sbReturn = new StringBuilder();
        var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
        foreach (char letter in arrayText)
        {
            if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                sbReturn.Append(letter);
        }
        return sbReturn.ToString();
    }
}
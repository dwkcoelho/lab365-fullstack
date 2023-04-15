namespace quiz.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int Quiz_Id { get; set; }
        public string Enunciation { get; set; }
        public decimal Weight { get; set; }

        public virtual Quiz Quiz { get; set; }
    }
}

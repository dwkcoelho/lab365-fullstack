namespace quiz.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int Question_Id { get; set; }
        public int Student_Id { get; set; }
        public string Answer_Result { get; set; }
        public float Score { get; set; }
        public string Observation { get; set; }

        public virtual Question Question { get; set; }
        public virtual Student Student { get; set; }
    }
}

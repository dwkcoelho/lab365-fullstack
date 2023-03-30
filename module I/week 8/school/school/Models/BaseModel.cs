namespace school.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public DateTime InclusionDate { get; set; }

        public DateTime ChangeDate { get; set; }
    }
}

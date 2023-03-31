namespace bercario.Models
{
    public class Parto
    {
        public int Id { get; set; }
        public int MedicoId { get; set; }
        public DateTime DataParto { get; set; }
        public DateTime HorarioParto { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<Mae> Maes { get; set; }
    }
}

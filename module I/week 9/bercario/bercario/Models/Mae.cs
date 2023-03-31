namespace bercario.Models
{
    public class Mae
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public virtual ICollection<Parto> Partos { get; set; }

    }
}

using System;
using System.Collections.Generic;

namespace pizzaria.Models;

public partial class Pizza
{
    public int IdPizza { get; set; }

    public int MassaId { get; set; }

    public int BordaId { get; set; }

    public virtual Bordum Borda { get; set; } = null!;

    public virtual Massa Massa { get; set; } = null!;

    public virtual Pedido? Pedido { get; set; }

    public virtual ICollection<PizzaSabore> PizzaSabores { get; } = new List<PizzaSabore>();
}

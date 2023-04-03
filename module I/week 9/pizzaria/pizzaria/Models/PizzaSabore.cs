using System;
using System.Collections.Generic;

namespace pizzaria.Models;

public partial class PizzaSabore
{
    public int IdPizzaSabores { get; set; }

    public int PizzaId { get; set; }

    public int SaborId { get; set; }

    public virtual Pizza Pizza { get; set; } = null!;

    public virtual Sabor Sabor { get; set; } = null!;
}

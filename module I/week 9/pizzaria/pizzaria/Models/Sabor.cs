using System;
using System.Collections.Generic;

namespace pizzaria.Models;

public partial class Sabor
{
    public int IdSabor { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<PizzaSabore> PizzaSabores { get; } = new List<PizzaSabore>();
}

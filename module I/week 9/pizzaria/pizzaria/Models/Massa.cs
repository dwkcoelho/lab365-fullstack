using System;
using System.Collections.Generic;

namespace pizzaria.Models;

public partial class Massa
{
    public int IdMassa { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Pizza> Pizzas { get; } = new List<Pizza>();
}

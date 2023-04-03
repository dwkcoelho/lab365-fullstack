using System;
using System.Collections.Generic;

namespace pizzaria.Models;

public partial class Status
{
    public int IdStatus { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; } = new List<Pedido>();
}

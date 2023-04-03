using System;
using System.Collections.Generic;

namespace pizzaria.Models;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public int PizzaId { get; set; }

    public int StatusId { get; set; }

    public virtual Pizza Pizza { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}

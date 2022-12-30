using System;
using System.Collections.Generic;

namespace DB2Backend.Models;

public partial class WyksztalcenieObywatel
{
    public int Id { get; set; }

    public int WyksztalcenieId { get; set; }

    public int ObywatelId { get; set; }

    public virtual Obywatel Obywatel { get; set; } = null!;

    public virtual Wyksztalcenie Wyksztalcenie { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace DB2Backend.Models;

public partial class ObywatelstwoObywatel
{
    public int Id { get; set; }

    public int ObywatelstwoId { get; set; }

    public int ObywatelId { get; set; }

    public virtual Obywatel Obywatel { get; set; } = null!;

    public virtual Obywatelstwo Obywatelstwo { get; set; } = null!;
}

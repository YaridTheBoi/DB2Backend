using System;
using System.Collections.Generic;

namespace DB2Backend.Models;

public partial class JezykObywatel
{
    public int Id { get; set; }

    public int JezykId { get; set; }

    public int ObywatelId { get; set; }

    public virtual Jezyk Jezyk { get; set; } = null!;

    public virtual Obywatel Obywatel { get; set; } = null!;
}

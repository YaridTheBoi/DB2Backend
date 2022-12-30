using System;
using System.Collections.Generic;

namespace DB2Backend.Models;

public partial class Wojewodztwo
{
    public int Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public virtual ICollection<Obywatel> Obywatels { get; } = new List<Obywatel>();
}

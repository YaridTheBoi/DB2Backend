using System;
using System.Collections.Generic;

namespace DB2Backend.Models;

public partial class KontoPortalu
{
    public int Id { get; set; }

    public bool CzyUrzednik { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<Obywatel> Obywatels { get; } = new List<Obywatel>();
}

using System;
using System.Collections.Generic;

namespace DB2Backend.Models;

public partial class Wyksztalcenie
{
    public int Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Stopien { get; set; } = null!;

    public virtual ICollection<WyksztalcenieObywatel> WyksztalcenieObywatels { get; } = new List<WyksztalcenieObywatel>();
}

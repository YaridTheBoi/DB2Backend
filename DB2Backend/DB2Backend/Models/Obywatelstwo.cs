using System;
using System.Collections.Generic;

namespace DB2Backend.Models;

public partial class Obywatelstwo
{
    public int Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public bool CzyPierwotne { get; set; }

    public virtual ICollection<ObywatelstwoObywatel> ObywatelstwoObywatels { get; } = new List<ObywatelstwoObywatel>();
}

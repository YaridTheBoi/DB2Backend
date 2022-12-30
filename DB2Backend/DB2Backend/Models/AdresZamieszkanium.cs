using System;
using System.Collections.Generic;

namespace DB2Backend.Models;

public partial class AdresZamieszkanium
{
    public int Id { get; set; }

    public string Kraj { get; set; } = null!;

    public string Miasto { get; set; } = null!;

    public string Ulica { get; set; } = null!;

    public int NrDomu { get; set; }

    public int? NrMieszkania { get; set; }

    public virtual ICollection<Obywatel> Obywatels { get; } = new List<Obywatel>();
}

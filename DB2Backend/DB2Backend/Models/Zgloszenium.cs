using System;
using System.Collections.Generic;

namespace DB2Backend.Models;

public partial class Zgloszenium
{
    public int Id { get; set; }

    public int IdZglaszajacego { get; set; }

    public string Tresc { get; set; } = null!;

    public bool CzyRozpatrzone { get; set; }

    public virtual Obywatel IdZglaszajacegoNavigation { get; set; } = null!;
}

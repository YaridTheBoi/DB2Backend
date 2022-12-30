using System;
using System.Collections.Generic;

namespace DB2Backend.Models;

public partial class Jezyk
{
    public int Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public bool CzyOjczysty { get; set; }

    public virtual ICollection<JezykObywatel> JezykObywatels { get; } = new List<JezykObywatel>();
}

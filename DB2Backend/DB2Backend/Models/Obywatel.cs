using System;
using System.Collections.Generic;

namespace DB2Backend.Models;

public partial class Obywatel
{
    public int Id { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string Pesel { get; set; } = null!;

    public DateTime DataUrodzenia { get; set; }

    public int Plec { get; set; }

    public int Wojewodztwo { get; set; }

    public int AdresZamieszkania { get; set; }

    public int? KontoPortalu { get; set; }

    public int NrDokumentu { get; set; }

    public virtual AdresZamieszkanium AdresZamieszkaniaNavigation { get; set; } = null!;

    public virtual ICollection<JezykObywatel> JezykObywatels { get; } = new List<JezykObywatel>();

    public virtual KontoPortalu? KontoPortaluNavigation { get; set; }

    public virtual ICollection<ObywatelstwoObywatel> ObywatelstwoObywatels { get; } = new List<ObywatelstwoObywatel>();

    public virtual Plec PlecNavigation { get; set; } = null!;

    public virtual Wojewodztwo WojewodztwoNavigation { get; set; } = null!;

    public virtual ICollection<WyksztalcenieObywatel> WyksztalcenieObywatels { get; } = new List<WyksztalcenieObywatel>();

    public virtual ICollection<Zgloszenium> Zgloszenia { get; } = new List<Zgloszenium>();
}

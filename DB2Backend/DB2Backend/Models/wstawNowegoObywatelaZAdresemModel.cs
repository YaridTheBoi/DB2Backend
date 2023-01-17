namespace DB2Backend.Models
{
    public class wstawNowegoObywatelaZAdresemModel
    {

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public string PESEL { get; set; }
        

        public string Data { get; set; }
        public int Plec { get; set; }

        public int Wojewodztwo { get; set; }   

        public int Konto { get; set; }
        
        public int Dokument { get; set; }

        public string Kraj { get; set; }

        public string Miasto { get; set; }

        public string Ulica { get; set; }

        public int Nr_domu { get; set; }


        public int Nr_mieszkania { get; set; }


    }
}

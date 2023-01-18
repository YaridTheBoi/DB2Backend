using DB2Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace DB2Backend.Services
{
    public class PracownikService : IPracownikService
    {

        private Db2Context context = new Db2Context();

        public Obywatel getInfoOObywateluPoPeselu(string pesel)
        {
            var ret=context.Obywatels.FirstOrDefault(m => m.Pesel == pesel);
            return ret;
        }

        public int postNowyObywatelZAdresem(wstawNowegoObywatelaZAdresemModel input)
        {
            var doesExist = context.Obywatels.FirstOrDefault(m => m.Pesel == input.PESEL);
            if(doesExist == null)
            {

                var adressExists = context.AdresZamieszkania.FirstOrDefault(m => (m.Kraj == input.Kraj) &&(m.Ulica==input.Ulica) && (m.NrMieszkania == input.Nr_mieszkania) && (m.Miasto == input.Miasto) && (m.NrDomu==input.Nr_domu));
                if(adressExists == null) {
                    Console.Write($"execute wstawNowegoObywatelaZAdresem '{input.Imie}','{input.Nazwisko}','{input.PESEL}','{input.Data}',{input.Plec},{input.Wojewodztwo},{input.Konto}, {input.Dokument},'{input.Kraj}',' {input.Miasto}','{input.Ulica}',{input.Nr_domu},{input.Nr_mieszkania};");
                    var res = context.Database.ExecuteSqlRaw($"execute wstawNowegoObywatelaZAdresem '{input.Imie}','{input.Nazwisko}','{input.PESEL}','{input.Data}',{input.Plec},{input.Wojewodztwo},{input.Konto}, {input.Dokument},'{input.Kraj}',' {input.Miasto}','{input.Ulica}',{input.Nr_domu},{input.Nr_mieszkania};");
                } else
                {
                    var res = context.Database.ExecuteSqlRaw($"execute wstawNowegoObywatela '{input.Imie}','{input.Nazwisko}','{input.PESEL}','{input.Data}',{input.Plec},{input.Wojewodztwo},{adressExists.Id},{input.Konto}, {input.Dokument};");
                }

                //Console.Write( res );
                
                return 1;
            }

            return 0;
        }
    }
}

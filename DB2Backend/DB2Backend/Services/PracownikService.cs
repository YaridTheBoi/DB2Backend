using DB2Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace DB2Backend.Services
{
    public class PracownikService : IPracownikService
    {

        private Db2Context context = new Db2Context();
        public int postNowyObywatelZAdresem(wstawNowegoObywatelaZAdresemModel input)
        {
            var doesExist = context.Obywatels.FirstOrDefault(m => m.Pesel == input.PESEL);
            if(doesExist == null)
            {
               // var res = context.wstawNowegoObywatelaZAdresem.FromSql($"wstawNowegoObywatelaZAdresem {input.Imie}, {input.Nazwisko}, {input.PESEL}, {input.Data}, {input.Plec}, {input.Wojewodztwo}, {input.Konto}, {input.Dokument}, {input.Kraj}, {input.Miasto}, {input.Ulica}, {input.Nr_domu}, {input.Nr_mieszkania}");
                //var res=context.Database.ExecuteSql($"wstawNowegoObywatelaZAdresem '{input.Imie}','{input.Nazwisko}','{input.PESEL}',{input.Data},{input.Plec},{input.Wojewodztwo},{input.Konto}, {input.Dokument},'{input.Kraj}',' {input.Miasto}','{input.Ulica}',{input.Nr_domu},{input.Nr_mieszkania};");
                //Console.Write( res );
                return 1;
            }

            return 0;
        }
    }
}

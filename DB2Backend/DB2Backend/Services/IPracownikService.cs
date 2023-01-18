using DB2Backend.Models;

namespace DB2Backend.Services
{
    public interface IPracownikService
    {

        public int postNowyObywatelZAdresem( wstawNowegoObywatelaZAdresemModel input);
        Obywatel getInfoOObywateluPoPeselu(string pesel);
    }
}

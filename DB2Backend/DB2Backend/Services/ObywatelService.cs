using DB2Backend.Models;
using Microsoft.EntityFrameworkCore;
namespace DB2Backend.Services
{
    public class ObywatelService : IObywatelService
    {

        private Db2Context context = new Db2Context();

        public List<obywateleWojewodztwoProcentModels> getObywateleWojewodztwoProcent(string wojewodztwo)
        {
            var res = context.obywateleWojewodztwoProcent.FromSql($"obywateleWojewodztwoProcent {wojewodztwo}");
            return res.ToList();
        }

        public List<procentKobietZWyzszymModel> getProcentKobietZWyzszym()
        {
            var res = context.procentKobietZWyzszym.FromSql($"procentKobietZWyzszym");
            return res.ToList();
        }

        public List<procentMezczyznZWyzszymModel> getProcentMezczyznZWyzszym()
        {
            var res = context.procentMezczyznZWyzszym.FromSql($"procentMezczyznZWyzszym");
            return res.ToList();
        }

        public List<procentMieszkajacyWkrajuModel> getProcentMieszkajacyWkraju(string kraj)
        {
            var res = context.procentMieszkajacyWkraju.FromSql($"procentMieszkajacyWkraju {kraj}");
            return res.ToList();
        }

        public List<procentObywateliMowiacychPoPolskuNieOjczyscieModel> getProcentObywateliMowiacychPoPolskuNieOjczyscie()
        {
            var res = context.procentObywateliMowiacychPoPolskuNieOjczyscie.FromSql($"procentObywateliMowiacychPoPolskuNieOjczyscie");
            return res.ToList();
        }


        public List<procentObywateliONazwiskuModel> getProcentObywateliONazwisku(string nazwisko)
        {
            var res = context.procentObywateliONazwisku.FromSql($"procentObywateliONazwisku {nazwisko}");
            return res.ToList();
        }

        public List<procentObywateliZOjczystymModel> getProcentObywateliZOjczystym(string ojczysty)
        {
            var res = context.procentObywateliZOjczystym.FromSql($"procentObywateliZOjczystym {ojczysty}");
            return res.ToList();
        }

        public List<procentPlciModel> getProcentPlci()
        {
            var res = context.procentPlci.FromSql($"procentPlci");
            return res.ToList();
        }
    }
}

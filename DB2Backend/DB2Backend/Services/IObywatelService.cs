using DB2Backend.Models;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;

namespace DB2Backend.Services
{
    public interface IObywatelService
    {

        List<procentPlciModel> getProcentPlci();

        List<procentKobietZWyzszymModel> getProcentKobietZWyzszym();

        List<procentMezczyznZWyzszymModel> getProcentMezczyznZWyzszym();

        List<procentMieszkajacyWkrajuModel> getProcentMieszkajacyWkraju(string kraj);

        List<procentObywateliMowiacychPoPolskuNieOjczyscieModel> getProcentObywateliMowiacychPoPolskuNieOjczyscie();

        List<procentObywateliONazwiskuModel> getProcentObywateliONazwisku(string nazwisko);

        List<procentObywateliZOjczystymModel> getProcentObywateliZOjczystym(string ojczysty);

        List<obywateleWojewodztwoProcentModels> getObywateleWojewodztwoProcent(string wojewodztwo);
    }
}

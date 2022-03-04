//ADO.NET è un set di classi che espongono servizi di accesso ai dati per i programmatori
using System.Data;
using Esercizio1.Models.ViewModels;
using Esercizio1.Models.Services.Infrastructure;

namespace Esercizio1.Models.Services.Application{
    public class AdoNetTupleService : IEsercizio1Service
    {
        private readonly IDatabaseAccessor db;

        public AdoNetTupleService(IDatabaseAccessor db)
        {
            this.db = db;
        }
        public List<Esercizio1ViewModel> getTuple()
        {string q="SELECT ID_Project, ID_Employee, Data, Ore FROM SvoltoDa";
        DataSet dataSet=db.Query(q);
        var dataTable=dataSet.Tables[0];
        var tuplaList=new List<Esercizio1ViewModel>();
        foreach(DataRow tuplaRow in dataTable.Rows){
var tupla=Esercizio1ViewModel.FromDataRow(tuplaRow);
tuplaList.Add(tupla);
        }
            return tuplaList;
        }
    }
}
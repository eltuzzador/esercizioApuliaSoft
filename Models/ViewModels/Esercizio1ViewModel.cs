using System.Data;

namespace Esercizio1.Models.ViewModels
{
    public class Esercizio1ViewModel
    {

        
        public string project = "";
        public string Project
        {
            get
            {
                return this.project;
            }
            set
            {
                this.project = value;//passo il nuovo valore che verrà assegnato dal servizio gfetService
            }
        }
        public string Employee {get;set;}="";
       
        public string Date{get;set;}="";//assegnazione di default;
        public int Hours { get; set; }=0;

        public static Esercizio1ViewModel FromDataRow(DataRow tuplaRow)
        {//leggo i valori dal database e li passo al ViewModel per la visualizzazione

        
            var tuplaViewModel=new Esercizio1ViewModel();
           if(tuplaRow.Table.Columns.Contains("ID_Project"))  tuplaViewModel.Project=(string)(tuplaRow["ID_Project"]);
            if(tuplaRow.Table.Columns.Contains("ID_Employee"))  tuplaViewModel.Employee=(string)tuplaRow["ID_Employee"];
            if(tuplaRow.Table.Columns.Contains("Data")) tuplaViewModel.Date=(string)tuplaRow["Data"];
            if(tuplaRow.Table.Columns.Contains("Ore"))tuplaViewModel.Hours=Convert.ToInt32(tuplaRow["Ore"]);
           
if(tuplaRow.Table.Columns.Contains("SUM(Ore)"))tuplaViewModel.Hours=Convert.ToInt32(tuplaRow["SUM(Ore)"]);
            return tuplaViewModel;
        }
    }
}
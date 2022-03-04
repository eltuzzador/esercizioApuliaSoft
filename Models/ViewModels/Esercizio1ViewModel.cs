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
            var tuplaViewModel=new Esercizio1ViewModel{
              Project=(string)(tuplaRow["ID_Project"]),
              Employee=(string)tuplaRow["ID_Employee"],
              Date=(string)tuplaRow["Data"],
              Hours=Convert.ToInt32(tuplaRow["Ore"])
            };

            return tuplaViewModel;
        }
    }
}
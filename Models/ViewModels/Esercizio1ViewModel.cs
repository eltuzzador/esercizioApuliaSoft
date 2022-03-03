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
    }
}
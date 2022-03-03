using System;
using Esercizio1.Models.ViewModels;

namespace Esercizio1.Models.Services.Application{
    public class Esercizio1Service
    {
        public List<Esercizio1ViewModel> getServices()
        {
            var tupleList=new List<Esercizio1ViewModel>();
            var rand=new Random();
        
                var tupla1=new Esercizio1ViewModel{
                    Project="Mars Rover",
                    
                    Employee="Mario",
                    Date="27 Aug 2021",
                    Hours=5
                };
                
          tupleList.Add(tupla1);
          var tupla2=new Esercizio1ViewModel{
                    Project="Manhattan",
                    
                    Employee="Giovanni",
                    Date="31 Aug 2021",
                    Hours=3
                };
                
          tupleList.Add(tupla2);
          var tupla3=new Esercizio1ViewModel{
                    Project="Mars Rover",
                    
                    Employee="Mario",
                    Date="01 Sep 2021",
                    Hours=3
                };
                
          tupleList.Add(tupla3);
          var tupla4=new Esercizio1ViewModel{
                    Project="Mars Rover",
                    
                    Employee="Lucia",
                    Date="01 Sep 2021",
                    Hours=3
                };
                
          tupleList.Add(tupla4);
          var tupla5=new Esercizio1ViewModel{
                    Project="Manhattan",
                    
                    Employee="Mario",
                    Date="27 Aug 2021",
                    Hours=2
                };
                
          tupleList.Add(tupla5);
          var tupla6=new Esercizio1ViewModel{
                    Project="Manhattan",
                    
                    Employee="Giovanni",
                    Date="01 Sep 2021",
                    Hours=4
                };
                
          tupleList.Add(tupla6);
return tupleList;
        }
    }

}
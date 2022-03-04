

using System.Data;
using Microsoft.Data.Sqlite;

namespace Esercizio1.Models.Services.Infrastructure
{
    public class SqLiteDabaseAccessor : IDatabaseAccessor
    {
        public DataSet Query(string query)
        {
            using (var conn = new SqliteConnection("Data Source=Data/data.db"))//mi assicuro che la connessione si chiuda anche se avviene eccezione o altro
            { 
                conn.Open();  //chiedo una connessione al connection pool che userò
                var cmd = new SqliteCommand(query, conn);  //SqliteCommand(stringa query, connessione);
                var reader = cmd.ExecuteReader();
                var dataSet= new DataSet();
                var DataTable=new DataTable();
                dataSet.Tables.Add(DataTable);
                DataTable.Load(reader);
                return dataSet;
            }
            //conn.Dispose(); //chiudo la connessione in modo non sicuro
          
        }
    }
}
using System.Data;

namespace Esercizio1.Models.Services.Infrastructure
{
    public interface IDatabaseAccessor
    {
        DataSet Query(string query);
    }
}
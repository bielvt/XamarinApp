using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace XamarinApp
{
    public class BaseDeDatos
    {
        readonly SQLiteAsyncConnection _database;

        public  BaseDeDatos(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Empleados>().Wait();
        }

        public Task<List<Empleados>> GetPeopleAsync()
        {
            return _database.Table<Empleados>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Empleados person)
        {
            return _database.InsertAsync(person);
        }
    }
}

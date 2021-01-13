using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TP.Models
{
    public  class Data
    {
        readonly SQLiteAsyncConnection _database;

        public Data(String dbpath)
        {
            _database = new SQLiteAsyncConnection(dbpath);
            _database.CreateTableAsync<User>().Wait();
        }
        public Task<List<User>> getUsersAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<User> getUserAsync(string email)
        {
            return _database.Table<User>().Where(u => u.Email == email).FirstOrDefaultAsync();
        }
        public Task<int> addUserasync(User user)
        {
            return _database.InsertAsync(user);
        }
    }
}

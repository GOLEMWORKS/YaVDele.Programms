using SQLite;

namespace YaVDele.CalculatorGrant.Data
{
    public class AppDBContext
    {
        SQLiteAsyncConnection Database;

        public AppDBContext()
        {
        }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<VolounteresJobList>();
        }
        public async Task<List<VolounteresJobList>> GetItemsAsync()
        {
            await Init();
            return await Database.Table<VolounteresJobList>().ToListAsync();
        }
    }
}

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
        public async Task<VolounteresJobList> GetItemsAsync(int id)
        {
            await Init();
            return await Database.Table<VolounteresJobList>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }
        public async Task<int> SaveItemsAsync(VolounteresJobList item)
        {
            await Init();
            if(item.Id != 0)
                return await Database.UpdateAsync(item);
            else
                return await Database.InsertAsync(item);
        }
        public async Task<int> DeleteItemAsync(VolounteresJobList item)
        {
            await Init();
            return await Database.DeleteAsync(item);
        }
    }
}

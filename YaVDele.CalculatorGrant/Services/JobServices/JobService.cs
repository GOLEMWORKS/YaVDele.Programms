using SQLite;
using YaVDele.CalculatorGrant.Data;

namespace YaVDele.CalculatorGrant.Services.JobServices
{
    public class JobService : IJobRepository
    {
        public SQLiteAsyncConnection _database;
        string _dbPath;

        public JobService(string dbPath)
        {
            _dbPath = dbPath;
            InitAsync();
        }

        private async Task InitAsync()
        {
            if (_database != null)
            {
                return;
            }
            _database = new SQLiteAsyncConnection(_dbPath);
            await _database.CreateTableAsync<VolounteerJobInfo>();
        }

        public async Task<bool> AddUpdateJobAsync(VolounteerJobInfo jobInfo)
        {
            if (jobInfo.Id > 0) await _database.UpdateAsync(jobInfo);
            else await _database.InsertAsync(jobInfo);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteJobAsync(int jobId)
        {
            await _database.DeleteAsync(jobId);
            return await Task.FromResult(true);
        }

        public async Task<IEnumerable<VolounteerJobInfo>> GetJobAsync()
        {
            await InitAsync();
            return await Task.FromResult(await _database.Table<VolounteerJobInfo>().ToListAsync());
        }

        public async Task<VolounteerJobInfo> GetJobsAsync(int jobId)
        {
            var res = await _database.Table<VolounteerJobInfo>().FirstOrDefaultAsync(p => p.Id == jobId);
            return res;
        }
    }
}

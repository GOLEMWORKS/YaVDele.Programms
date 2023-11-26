using YaVDele.CalculatorGrant.Data;

namespace YaVDele.CalculatorGrant.Services.JobServices
{
    public interface IJobRepository
    {
        Task<bool> AddUpdateJobAsync(VolounteerJobInfo jobInfo);
        Task<bool> DeleteJobAsync(int jobId);
        Task<VolounteerJobInfo> GetJobsAsync(int jobId);
        Task<IEnumerable<VolounteerJobInfo>> GetJobAsync();
    }
}

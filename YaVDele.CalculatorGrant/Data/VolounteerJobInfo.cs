using SQLite;

namespace YaVDele.CalculatorGrant.Data
{
    public class VolounteerJobInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string  JobName { get; set; }
        public double Salary { get; set; }
    }
}

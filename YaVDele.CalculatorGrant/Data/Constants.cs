namespace YaVDele.CalculatorGrant.Data
{
    public class Constants
    {
        public const string DBfilename = "AppDB.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DBfilename);
    }
}

namespace YaVDele.CalculatorGrant.Data
{
    public class FileLogic : FileUpload
    {
        public void FileDelete(string fileName)
        {
            string pathToDelete = Path.Combine(MainDirInit(), fileName);
            if (File.Exists(pathToDelete)) File.Delete(pathToDelete);
        }

        public void FileReadAsTable(string path, string fileName)
        {

        }
    }
}

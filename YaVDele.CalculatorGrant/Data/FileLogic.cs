using YaVDele.CalculatorGrant.Data.Objects;

namespace YaVDele.CalculatorGrant.Data
{
    public class FileLogic : FileUpload
    {
        public void FileDelete(FileObject file)
        {
            string pathToDelete = Path.Combine(file.FilePath, file.FileName);
            if (File.Exists(pathToDelete)) File.Delete(pathToDelete);
        }

        public void FileReadAsTable(string path, string fileName)
        {

        }
    }
}
